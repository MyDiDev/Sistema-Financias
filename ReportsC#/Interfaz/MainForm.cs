using ReportsC_.Interfaz.FReportes;
using System;
using Logica.clases;
using System.Windows.Forms;
using System.Collections.Generic;
using ReportsC_.Interfaz.Login;
using ReportsC_.FinanciasDataSetTableAdapters;
using ReportsC_.Interfaz.ClientData;
using ReportsC_.Interfaz.RegisterF;

namespace ReportsC_.Interfaz
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public int UID;

        private Form openForm = null;
        private void OpenForm(Form f)
        {
            if (openForm != null)
            {
                openForm.Close();
                formPanel.Controls.Remove(openForm);
                openForm.Dispose();
            }

            openForm = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            formPanel.Controls.Add(f);
            formPanel.Tag = f.Tag;
            f.BringToFront();
            f.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void listClientBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void totalesBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void listClientBtn2_Click(object sender, EventArgs e)
        {
            
        }

        private void clientListM_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportsForm f = new ReportsForm();
            OpenForm(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm f = new RegisterForm();
            OpenForm(f);
        }

        private void clientInfoBtn_Click(object sender, EventArgs e)
        {
            RegistraForm r = new RegistraForm();
            Cliente c = new Cliente(id:UID);

            r.mode = "update";
            
            List<string> data = c.getData();

            r.Nombre = data[0];            
            r.Correo = data[1];
            r.Telefono = data[2];
            r.Direccion = data[3];
            r.Sueldo = Convert.ToDouble(data[4]);
            r.Garantia = data[5];
            r.Id = UID;

            OpenForm(r);
        }

        private void clientLoanInfoBtn_Click(object sender, EventArgs e)
        {
            Prestamo p = new Prestamo(UID);
            CientDataForm f = new CientDataForm();

            f.data.DataSource = p.getLoanData();
            OpenForm(f);
        }

        private void clientAmInfoBtn_Click(object sender, EventArgs e)
        {
            Prestamo p = new Prestamo(UID);
            int prestamoId = p.getLoanId();
            Amortizacion a = new Amortizacion(prestamoId);
            CientDataForm f = new CientDataForm();

            f.data.DataSource = a.getAmortizacionData();
            OpenForm(f);
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            RegisterPrestamos f = new RegisterPrestamos();
            OpenForm(f);
        }
    }
}
