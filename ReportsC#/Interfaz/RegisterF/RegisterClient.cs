using System;
using System.Windows.Forms;
using Logica.clases;

namespace ReportsC_
{
    public partial class RegisterClient : Form
    {
        public RegisterClient()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            if (string.IsNullOrEmpty(nameClient.Text) || string.IsNullOrEmpty(mailClient.Text) ||
                string.IsNullOrEmpty(phoneClient.Text) || string.IsNullOrEmpty(direcClient.Text) || string.IsNullOrEmpty(warranty.Text)
                || salaryClient.Value == 0)
            {
                errMsg.Text = "Llene el formulario";
                return;
            }

            Cliente cliente = new Cliente(nameClient.Text, mailClient.Text, phoneClient.Text, direcClient.Text, warranty.Text, (double)salaryClient.Value, (int)moraClient.Value);
            
            if (cliente.addClient())
            {
                MessageBox.Show("Cliente Agregado Exitosamente","EXITO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else
            {
                errMsg.Text = "No se pudo agregar al cliente, considere el formato";
            }
        }
    }
}
