using Logica.clases;
using System;
using System.Windows.Forms;

namespace ReportsC_.Interfaz.Login
{
    public partial class RegistraForm : Form
    {

        public RegistraForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        public string mode;

        public int Id;
        public string Nombre;
        public string Correo;
        public string Telefono;
        public string Direccion;
        public string Garantia;
        public double Sueldo;

        private void btn_Click(object sender, EventArgs e)
        {

            Cliente c = new Cliente(nameClient.Text, mailClient.Text, phoneClient.Text, direcClient.Text, (double)salaryClient.Value, Garantia);
         
            switch (mode)
            {
                case "update":
                    bool result = c.updateClient(Id);

                    if (result)
                    { 
                        MessageBox.Show("Datos Actualizados Exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudieron actualizar los datos, considere el formato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "register":
                    if (!c.addClient())
                    {
                        MessageBox.Show("NO SE PUDO AGREGAR LOS DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Datos Agregados exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case "update":
                    title.Text = "Info Personal";
                    label7.Visible = false;
                    btn.Text = "Actualizar Info";

                    nameClient.Text = Nombre;
                    mailClient.Text = Correo;
                    phoneClient.Text = Telefono;
                    direcClient.Text = Direccion;
                    warranty.Text = Garantia;
                    salaryClient.Value = (decimal)Sueldo;
                    break;
            }
        }
    }
}
