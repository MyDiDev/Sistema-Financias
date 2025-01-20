using Logica.clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ReportsC_.Interfaz.RegisterF
{
    public partial class RegisterPrestamos : Form
    {
        public RegisterPrestamos()
        {
            InitializeComponent();
        }

        public decimal Salary;
        public string Correo;
        public int UID;

        public void CalcFinanzas()
        {
            try
            {
                Cliente c = new Cliente("", nameClient.Text);
                Salary = c.getSalary();

                if (Salary == 0)
                    return;
             
                Prestamo p = new Prestamo(0, (int)months.Value);
                amount.Value = p.CalcularMontoTotal(Salary);
                interes.Value = (decimal)p.CalcularInteresSalario((double)amount.Value);

                errMsg.LinkColor = Color.LightGreen;
                errMsg.Text = "Correo Encontrado!, Monto calculado";
            }
            catch (ArgumentOutOfRangeException)
            {
                errMsg.Text = "Correo Invalido!";
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameClient.Text.Trim()) || amount.Value == 0)
            {
                errMsg.Text = "Llene el formulario";
                return;
            }


            Prestamo p = new Prestamo(UID, (int)months.Value, (double)amount.Value);

            if (p.checkPrestamo())
            {
                MessageBox.Show("Ya tiene un prestamo realizado","PRESTAMO YA REALIZADO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Close();
                return;
            }

            AmortizacionTableForm f = new AmortizacionTableForm();

            f.data.AutoGenerateColumns = true;
            f.Monto = (double)amount.Value;
            f.fechaPrestamo = DateTime.Now;
            f.UID = UID; 
            f.data.DataSource = p.CalcularAmortizacion();
            f.data.Refresh();
            f.mode = "calc";

            f.ShowDialog();
            Close();
        }

        private void nameClient_TextChanged(object sender, EventArgs e)
        {
            CalcFinanzas();
        }

        private void RegisterPrestamos_Load(object sender, EventArgs e)
        {
            nameClient.Text = Correo;
        }

        private void months_ValueChanged(object sender, EventArgs e)
        {
            CalcFinanzas();
        }
    }
}
