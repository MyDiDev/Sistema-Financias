using Logica.clases;
using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;
using ReportsC_.Interfaz.RegisterF;
using System;
using System.Data;
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
        public int mes;
        public DataTable Data;

        private DataTable getAmortizacion()
        {
            Prestamo p = new Prestamo(UID);
            int prestamoId = p.getLoanId();

            Amortizacion a = new Amortizacion(prestamoId);
            DataTable clientData = a.getRegisteredAmortizacion();


            return clientData;
        }

        private void CientDataForm_Load(object sender, EventArgs e)
        {
            data.DataSource = getAmortizacion();
        }

        private void amortizarBtn_Click(object sender, EventArgs e)
        {
            mes = 0;
            decimal montoAnterior = 0;
            decimal montoAbonado = 0;
            decimal nuevoMonto = 0;
            decimal intMora = 0;
            int mora = 0;

            foreach (DataRow row in Data.Rows)
            {
                mes = (int)row["Mes"];
                montoAnterior = (decimal)row["MontoAnterior"];
                montoAbonado = (decimal)row["MontoAbonado"];
                nuevoMonto = (decimal)row["NuevoMonto"];
                intMora = (decimal)row["InteresMora"];
                mora = (int)row["Mora"];
                break;
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

        private void CientDataForm_Close(object sender, FormClosingEventArgs e)
        {

        }
    }
}
