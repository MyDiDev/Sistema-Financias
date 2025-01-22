using Logica.clases;
using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            AmortizacionTableForm f = new AmortizacionTableForm();
            Prestamo p = new Prestamo(UID, (int)monthsLeft.Value, (double)sueldoAnterior.Value);

            f.data.AutoGenerateColumns = true;
            f.mode = "update";
            f.data.DataSource = p.RecalcularAmortizacion(sueldoAnterior.Value, (int)month.Value, couta,deposit.Value, (int)mora.Value);
            f.data.Refresh();
            f.UID = UID;

            f.ShowDialog();
        }

        private void mora_ValueChanged(object sender, EventArgs e)
        {
            if (mora.Value == 0)
                return;

            int Mes = ((int)month.Value <= 1) ? (int)month.Value : (int)month.Value - 1;
            Cliente c = new Cliente("", clientEmail.Text);
            Prestamo p = new Prestamo(UID, (int)monthsLeft.Value, (double)c.getSalary()*4);
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
        }

        private async void RegisterAmortizacionForm_Load(object sender, EventArgs e)
        {
            Cliente c = new Cliente(0);
            foreach(string name in c.getCorreos())
            {
                clientEmail.Items.Add(name);
            }
        }

        private void clientEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }
    }
}
