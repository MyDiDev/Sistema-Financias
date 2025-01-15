using System;
using System.Data;
using System.Windows.Forms;
using Logica.clases;
using Microsoft.Reporting.WinForms;
using ReportsC_.Interfaz.ErrorForm;

namespace ReportsC_.Interfaz
{
    public partial class MClientList : Form
    {
        public MClientList()
        {
            InitializeComponent();
        }

        private void MClientList_Load(object sender, EventArgs e)
        {
            this.totalMorasTableAdapter.Fill(this.financiasDataSet.TotalMoras);
            this.totalMorasTableAdapter.Fill(this.financiasDataSet.TotalMoras);

            if (this.financiasDataSet.TotalMoras.Rows.Count == 0)
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
