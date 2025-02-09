﻿using Logica.clases;
using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ReportsC_.Interfaz.RegisterF
{
    public partial class RegisterAmortizacionForm : Form
    {
        public RegisterAmortizacionForm()
        {
            InitializeComponent();
        }

        public int UID;
        public decimal couta;
        public decimal nuevoMonto;
        public string mode;
        public string Correo;

        private void button1_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case "register":
                    Prestamo p = new Prestamo(UID);
                    Amortizacion a = new Amortizacion(p.getLoanId(), (int)month.Value);

                    if (a.registerAmortizacion()){
                        MessageBox.Show("Amortizacion registrada");
                        Close();
                    }
                    break;
                default:
                    AmortizacionTableForm f = new AmortizacionTableForm();
                    Prestamo p2 = new Prestamo(UID, (int)monthsLeft.Value, (double)sueldoAnterior.Value);

                    f.data.AutoGenerateColumns = true;
                    f.mode = "update";
                    f.data.DataSource = p2.RecalcularAmortizacion(sueldoAnterior.Value, (int)month.Value, couta, deposit.Value, (int)mora.Value);
                    f.data.Refresh();
                    f.UID = UID;

                    f.ShowDialog();
                    break;
            }
        }

        private void mora_ValueChanged(object sender, EventArgs e)
        {
            switch (mode)
            {
                case "register":
                    break;
                default:
                    if (mora.Value == 0)
                        return;

                    int Mes = ((int)month.Value <= 1) ? (int)month.Value : (int)month.Value - 1;
                    Cliente c = new Cliente("", clientEmail.Text);
                    Prestamo p = new Prestamo(UID, (int)monthsLeft.Value, (double)c.getSalary() * 4);
                    Amortizacion a = new Amortizacion(p.getLoanId(), Mes);

                    if (monthsLeft.Value == 0)
                        return;

                    /*10,800
                    // 1,080
                    // 39,203 * 0.10 / 3 = 1,333
                    // 40,000 / 3 = 13,333
                    // 13,333 + 1,333 = 14,666
                    // 14,666 += 10,800 + 1,080 = 26,546
                     deposito - 26,546*/

                    couta = p.CalcularCuotaMensual();
                    couta += deposit.Value + intMora.Value;

                    intMora.Value = deposit.Value * 0.10M;
                    sueldoAnterior.Value = a.getLastSalary();
                    sueldoActual.Value = Math.Round(sueldoAnterior.Value - couta);
                    break;
            }
        }

        private async void RegisterAmortizacionForm_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case "register":
                    
                    if (couta == 0 && intMora.Value == 0 && sueldoAnterior.Value == 0 && sueldoActual.Value == 0
                        && month.Value == 0)
                    {
                        Prestamo p = new Prestamo(UID);
                        p.actualizarPrestamo(p.getLoanId());
                        MessageBox.Show("Ya no tienes mas amortizaciones", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    
                    clientEmail.Items.Add(Correo);
                    break;
                default:
                    Cliente c = new Cliente(0);
                    foreach (string name in c.getCorreos())
                    {
                        clientEmail.Items.Add(name);
                    }
                    break;
            }
        }

        private void clientEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mode)
            {
                case "register":
                    try
                    {
                        Cliente c = new Cliente("", clientEmail.Text);
                        UID = c.getId();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        return;
                    }
                    break;
                default:
                    try
                    {
                        Cliente c = new Cliente("", clientEmail.Text);
                        UID = c.getId();
                        Prestamo p = new Prestamo(UID);
                        Amortizacion a = new Amortizacion(p.getLoanId());


                        if (a.getDeposit() == -1)
                        {
                            return;
                        }

                        deposit.Value = a.getDeposit();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        return;
                    }
                    break;
            }
        }
    }
}
