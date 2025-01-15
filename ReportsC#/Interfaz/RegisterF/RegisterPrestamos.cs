using Logica.clases;
using System;
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
            if (string.IsNullOrEmpty(nameClient.Text) || string.IsNullOrEmpty(interesType.Text)
                || amount.Value == 0)
            {
                errMsg.Text = "Llene el formulario";
                return;
            }

            bool warranty = (warrantyValue.Text == "si") ? true : false;

            if (!warranty)
            {
                errMsg.Text = "No se puede realizar sin garantia";
                return;
            }

            Prestamo p = new Prestamo(0, (double)amount.Value, (int)months.Value, 0, DateTime.Now, warranty);
            Cliente c = new Cliente(nameClient.Text);

            decimal Salary = c.getSalary();

            if (p.RealizarPrestamo(nameClient.Text, interesType.Text, Salary, amount.Value, Salary, 0))
            {
                MessageBox.Show("Registro agregado!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                errMsg.Text = "No se pudo agregar registro";
            }
        }
    }
}
