using Logica.clases;
using ReportsC_.Interfaz.RegisterF;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReportsC_.Interfaz.ClientData
{
    public partial class CientDataForm : Form
    {
        public CientDataForm()
        {
            InitializeComponent();
        }

        public string Correo;
        public int UID;
        public decimal couta;

        private void CientDataForm_Load(object sender, EventArgs e)
        {
            if (title.Text == "Amortizaciones")
            {
                data.Size = new Size(900, 305);

                if (!string.IsNullOrEmpty(Correo))
                    clientEmail.Items.Add(Correo);

                //Labels
                mailClientLabel.Visible = true;
                depositLabel.Visible = true;
                moraLabel.Visible = true;
                intMoraLabel.Visible = true;
                sueldoALabel.Visible = true;
                sueldoActualLabel.Visible = true;
                mesNoLabel.Visible = true;
                mesLeftLabel.Visible = true;
                //button
                amortizarBtn.Visible = true;

                //inputs
                clientEmail.Visible = true;
                deposit.Visible = true;
                mora.Visible = true;
                intMora.Visible = true;
                sueldoAnterior.Visible = true;
                sueldoActual.Visible = true;
                month.Visible = true;
                monthsLeft.Visible = true;
                return;
            }

            //Labels
            mailClientLabel.Visible = false;
            depositLabel.Visible = false;
            moraLabel.Visible = false;
            intMoraLabel.Visible = false;
            sueldoALabel.Visible = false;
            sueldoActualLabel.Visible = false;
            mesNoLabel.Visible = false;
            mesLeftLabel.Visible = false;
            //button
            amortizarBtn.Visible = false;

            //inputs
            clientEmail.Visible = false;
            deposit.Visible = false;
            mora.Visible = false;
            intMora.Visible = false;
            sueldoAnterior.Visible = false;
            sueldoActual.Visible = false;
            month.Visible = false;
            monthsLeft.Visible = false;
        }


        private void clientEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente("", clientEmail.Text);
                UID = c.getId();
                Prestamo p = new Prestamo(UID);
                Amortizacion a = new Amortizacion(p.getLoanId());


                if (a.getDeposit() == -1){
                    return;
                }
                deposit.Value = a.getDeposit();
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
        }

        private void mora_ValueChanged(object sender, EventArgs e)
        {
            if (mora.Value == 0)
                return;

            int Mes = ((int)month.Value <= 1) ? (int)month.Value : (int)month.Value - 1;
            Cliente c = new Cliente("", clientEmail.Text);
            Prestamo p = new Prestamo(UID, (int)monthsLeft.Value, (double)c.getSalary() * 4);
            Amortizacion a = new Amortizacion(p.getLoanId(), Mes);

            if (monthsLeft.Value == 0)
                return;

            couta = p.CalcularCuotaMensual();
            couta += deposit.Value + intMora.Value;

            intMora.Value = deposit.Value * 0.10M;
            sueldoAnterior.Value = a.getLastSalary();
            sueldoActual.Value = Math.Round(sueldoAnterior.Value - couta);
        }

        private void amortizarBtn_Click(object sender, EventArgs e)
        {
            AmortizacionTableForm f = new AmortizacionTableForm();
            Prestamo p = new Prestamo(UID, (int)monthsLeft.Value, (double)sueldoAnterior.Value);

            f.data.AutoGenerateColumns = true;
            f.mode = "update";
            f.data.DataSource = p.RecalcularAmortizacion(sueldoAnterior.Value, (int)month.Value, couta, deposit.Value, (int)mora.Value);
            f.data.Refresh();
            f.UID = UID;
            f.button1.Visible = false;

            f.ShowDialog();
        }
    }
}
