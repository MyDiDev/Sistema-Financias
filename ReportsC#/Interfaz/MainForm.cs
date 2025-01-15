using ReportsC_.Interfaz.FReportes;
using System;
using System.Data;
using System.Windows.Forms;

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
            RegisterClient f = new RegisterClient();
            
            
            OpenForm(f);
        }
    }
}
