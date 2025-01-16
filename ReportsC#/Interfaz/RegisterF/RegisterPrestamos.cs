using Logica.clases;
using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameClient.Text.Trim()) || amount.Value == 0)
            {
                errMsg.Text = "Llene el formulario";
                return;
            }

            Prestamo p = new Prestamo(0, (double)amount.Value, (int)months.Value, 0, DateTime.Now, true);
            Cliente c = new Cliente(nameClient.Text);

            decimal Salary = c.getSalary();

            bool prestamoRealizado = p.RealizarPrestamo(nameClient.Text, Salary, amount.Value, 0, 0);

            if (prestamoRealizado)
            {
                MessageBox.Show("Préstamo Realizado!", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo realizar el préstamo. Verifique los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void nameClient_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente("", nameClient.Text, "", "", 0, "");
                decimal salary = c.getSalary();

                if (salary == 0)
                {
                    return;
                }
                else {
                    Prestamo p = new Prestamo(0, (int)months.Value);
                    amount.Value = p.CalcularMontoTotal(salary);

                    errMsg.ForeColor = Color.Green;
                    errMsg.Text = "Correo Encontrado!, Monto calculado";
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                errMsg.Text = "Correo Invalido!";
                return;
            }
        }
    }
}
