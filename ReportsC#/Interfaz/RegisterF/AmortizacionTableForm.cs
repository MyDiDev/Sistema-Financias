using Logica.clases;
using System;
using System.Windows.Forms;

namespace ReportsC_.Interfaz.RegisterF
{
    public partial class AmortizacionTableForm : Form
    {
        public AmortizacionTableForm()
        {
            InitializeComponent();
        }

        public int UID;
        public double Monto;
        public int Meses;
        public DateTime fechaPrestamo;
        public string mode;

        private void button1_Click(object sender, System.EventArgs e)
        {
            switch (mode)
            {
                case "calc":
                    DialogResult confirm = MessageBox.Show("Seguro quieres realizar este Prestamo?", "CONFIRMACION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (confirm != DialogResult.Yes)
                    {
                        Close();
                        return;
                    }

                    Prestamo p = new Prestamo(UID, Monto, Meses, 0, fechaPrestamo, true);
                    p.realizarPrestamo("En Proceso");

                    foreach (DataGridViewRow row in data.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            DateTime fechaPago = Convert.ToDateTime(row.Cells["FechaPago"].Value);
                            int mes = Convert.ToInt32(row.Cells["Mes"].Value);
                            decimal montoAnterior = Convert.ToDecimal(row.Cells["MontoAnterior"].Value);
                            decimal montoAbonado = Convert.ToDecimal(row.Cells["Deposito"].Value);
                            decimal montoNuevo = Convert.ToDecimal(row.Cells["NuevoMonto"].Value);
                            bool mora = false;
                            decimal interesMora = montoAbonado * (decimal)((mora) ? 0.10 : 0);


                            Amortizacion a = new Amortizacion(p.getLoanId(), fechaPago, mes, montoAnterior, montoAbonado, montoNuevo, interesMora, 0);
                            a.RealizarAmortizacion();
                        }
                    }
                    break;
                case "update":
                    DialogResult confirmReclac = MessageBox.Show("Seguro quieres realizar este Prestamo?", "CONFIRMACION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (confirmReclac != DialogResult.Yes)
                    {
                        Close();
                        return;
                    }

                    Prestamo p2 = new Prestamo(UID);

                    foreach (DataGridViewRow row in data.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            DateTime fechaPago = Convert.ToDateTime(row.Cells["FechaPago"].Value);
                            int mes = Convert.ToInt32(row.Cells["Mes"].Value);
                            decimal montoAnterior = Convert.ToDecimal(row.Cells["MontoAnterior"].Value);
                            decimal montoAbonado = Convert.ToDecimal(row.Cells["Deposito"].Value);
                            decimal montoNuevo = Convert.ToDecimal(row.Cells["NuevoMonto"].Value);
                            decimal Interes = Convert.ToDecimal(row.Cells["Interes"].Value);
                            decimal interesMora = Convert.ToDecimal(row.Cells["InteresMora"].Value);
                            int mora = Convert.ToInt32(row.Cells["Mora"].Value);

                            if (mora > 0)
                            {
                                Cliente c = new Cliente(UID);
                                c.agregarMora(mora);
                            }

                            Amortizacion a = new Amortizacion(p2.getLoanId(), fechaPago, mes, montoAnterior, montoAbonado, montoNuevo, interesMora, mora);
                            a.actualizarAmortizacion();
                        }
                    }
                    break;
            }

        }
    }
}
