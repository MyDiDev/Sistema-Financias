using ReportsC_.Interfaz.RegisterF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportsC_.Interfaz
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private Form openForm = null;
        private void OpenForm(Form f)
        {
            if (openForm != null)
            {
                openForm.Close();
                panelForm.Controls.Remove(openForm);
                openForm.Dispose();
            }

            openForm = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelForm.Controls.Add(f);
            panelForm.Tag = f.Tag;
            f.BringToFront();
            f.Show();
        }

        private void ClientBtn_Click(object sender, EventArgs e)
        {
            RegisterClient f = new RegisterClient();
            OpenForm(f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterPrestamos f = new RegisterPrestamos();
            OpenForm(f);
        }
    }
}
