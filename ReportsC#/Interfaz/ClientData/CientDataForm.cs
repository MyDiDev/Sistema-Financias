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
        }

        private void amortizarBtn_Click(object sender, EventArgs e)
        {
            int mes = 0;
            decimal montoAnterior = 0;
            decimal montoAbonado = 0;
            decimal nuevoMonto = 0;
            decimal intMora = 0;
            int mora = 0;

            foreach (DataGridViewRow row in data.SelectedRows)
            {
                mes = (int)row.Cells[2].Value;
                montoAnterior = (decimal)row.Cells[3].Value;
                montoAbonado = (decimal)row.Cells[4].Value;
                nuevoMonto = (decimal)row.Cells[5].Value;
                intMora = (decimal)row.Cells[6].Value;
                mora = Convert.ToInt32(row.Cells[7].Value);
            }

            RegisterAmortizacionForm f = new RegisterAmortizacionForm();
            f.mode = "register";
            f.month.Value = mes;
            f.month.Enabled = false;
            f.sueldoAnterior.Value = montoAnterior;
            f.deposit.Value = montoAbonado;
            f.sueldoActual.Value = nuevoMonto;
            f.intMora.Value = intMora;
            f.mora.Value = mora;
            f.mora.Enabled = false;
            f.label1.Text = "Mes";
            f.monthsLeft.Visible = false;
            f.Correo = Correo;
            f.button1.Text = "Registrar Amortizacion";
            f.label8.Visible = false;

            f.ShowDialog();
        }
    }
}
