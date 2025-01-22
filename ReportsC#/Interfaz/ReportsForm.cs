using ReportsC_.Interfaz.FReportes;
using ReportsC_.Interfaz.ReportesF;
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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void OpenForm(Form f)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                panelForm.Controls.Remove(activeForm);
                activeForm.Dispose();
            }

            activeForm = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelForm.Controls.Add(f);
            panelForm.Tag = f.Tag;
            f.BringToFront();
            f.Show();

        }

        private void listClientBtn_Click(object sender, EventArgs e)
        {
            ClientList f = new ClientList();
            OpenForm(f);
        }

        private void totalesBtn_Click(object sender, EventArgs e)
        {
            TotalsListForm f = new TotalsListForm();
            OpenForm(f);
        }

        private void clientListM_Click(object sender, EventArgs e)
        {
            MClientsList2 f = new MClientsList2();
            OpenForm(f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AmortizacionForm a = new AmortizacionForm();
            OpenForm(a);
        }

        private void listClientBtn2_Click(object sender, EventArgs e)
        {
            MClientList f = new MClientList();
            OpenForm(f);
        }
    }
}
