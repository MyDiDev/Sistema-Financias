using Logica.clases;
using System;
using System.Windows.Forms;

namespace ReportsC_.Interfaz.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameClient.Text) || string.IsNullOrEmpty(clientMail.Text))
            {
                MessageBox.Show("LLene el formulario","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            Admins a = new Admins(nameClient.Text, clientMail.Text);
            MainForm f = new MainForm();


            if (a.CheckAdmin())
            {
                int uid = a.getAdminID();

                MessageBox.Show($"Bienvenido {a.Nombre} ADMIN", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                f.isAdmin.Visible = true;

                f.UID = uid;

                f.adminBtnReport.Visible = true;
                f.registerAdminBtn.Visible = true;

                f.clientInfoBtn.Visible = false;
                f.clientLoanInfoBtn.Visible = false;
                f.clientAmInfoBtn.Visible = false;
                f.btnPrestamo.Visible = false;
                f.Show();
            }
            else
            {
                Cliente c = new Cliente(nameClient.Text, clientMail.Text);

                if (c.checkClient())
                {
                    int uid = c.getId();

                    MessageBox.Show($"Bienvenido {c.Nombre}", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f.isAdmin.Visible = false;
    
                    f.UID = uid;

                    f.adminBtnReport.Visible = false;
                    f.registerAdminBtn.Visible = false;

                    f.clientInfoBtn.Visible = true;
                    f.clientLoanInfoBtn.Visible = true;
                    f.clientAmInfoBtn.Visible = true;
                    f.btnPrestamo.Visible = true;

                    Hide();
                    f.Show();
                }
            }
        }
    }
}
