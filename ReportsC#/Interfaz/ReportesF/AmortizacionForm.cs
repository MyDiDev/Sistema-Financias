using Logica.clases;
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

namespace ReportsC_.Interfaz.ReportesF
{
    public partial class AmortizacionForm : Form
    {
        public AmortizacionForm()
        {
            InitializeComponent();
        }

        Amortizacion a = new Amortizacion(0);

 
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void AmortizacionForm_Load(object sender, EventArgs e)
        {
            int id = (string.IsNullOrEmpty(idComboBox.Text)) ? 1 : Convert.ToInt32(idComboBox.Text);
            this.amortiacionesFiltroIdTableAdapter.Fill(this.financiasDataSet.AmortiacionesFiltroId, id);
            
            if (this.financiasDataSet.AmortiacionesFiltroId.Rows.Count == 0)
            {
                ErrForm_cs f = new ErrForm_cs();
                f.errMsg.Text = "No se pudo encontrar el listado";
                f.ShowDialog();
                return;
            }

            foreach (var Id in a.getAmortizacionId())
            {
                idComboBox.Items.Add(Id);
            }

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (string.IsNullOrEmpty(idComboBox.Text)) ? 1 : Convert.ToInt32(idComboBox.Text);
            this.amortiacionesFiltroIdTableAdapter.Fill(this.financiasDataSet.AmortiacionesFiltroId, id);
            this.reportViewer1.RefreshReport();

        }
    }
}
