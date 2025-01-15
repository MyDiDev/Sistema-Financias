using Microsoft.Reporting.WinForms;
using ReportsC_.Interfaz.ErrorForm;
using System;
using System.Windows.Forms;

namespace ReportsC_.Interfaz.FReportes
{
    public partial class ClientList : Form
    {
        public ClientList()
        {
            InitializeComponent();
        }

        private void ClientList_Load(object sender, EventArgs e)
        {
            
            this.clientesTableAdapter.Fill(this.financiasDataSet.Clientes);
            
            if (this.financiasDataSet.Clientes.Rows.Count == 0)
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
