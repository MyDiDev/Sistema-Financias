using Microsoft.Reporting.WinForms;
using ReportsC_.Interfaz.ErrorForm;
using System;
using System.Windows.Forms;

namespace ReportsC_.Interfaz
{
    public partial class MClientsList2 : Form
    {
        public MClientsList2()
        {
            InitializeComponent();
        }

        private void MClientsList2_Load(object sender, EventArgs e)
        {
            
            this.clientesMorososTableAdapter.Fill(this.financiasDataSet.ClientesMorosos);
           
            if (this.financiasDataSet.ClientesMorosos.Rows.Count == 0)
            {
                ErrForm_cs f = new ErrForm_cs();
                f.errMsg.Text = "No se pudo encontrar el listado";
                f.ShowDialog();
                return;
            }

            reportViewer.RefreshReport();
            reportViewer.ZoomMode = ZoomMode.PageWidth;
        }
    }
}
