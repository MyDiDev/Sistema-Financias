using Logica.clases;
using Microsoft.Reporting.WinForms;
using ReportsC_.Interfaz.ErrorForm;
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
    public partial class TotalsListForm : Form
    {
        public TotalsListForm()
        {
            InitializeComponent();
        }

        private void TotalsListForm_Load(object sender, EventArgs e)
        {
            this.totales_PTableAdapter.Fill(this.financiasDataSet.Totales_P);

            if (this.financiasDataSet.Totales_P.Rows.Count == 0)
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
