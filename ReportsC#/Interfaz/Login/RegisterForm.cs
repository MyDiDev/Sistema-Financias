using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportsC_.Interfaz.Login
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        
        public string mode;

        public string Nombre;
        public string Correo;
        public string Telefono;
        public string Direccion;
        public string Garantia;
        public double Sueldo;

        private void btn_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case "update":
                    break;
                case "register":
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
                    salaryClient.Value = (decimal)Sueldo;
                    break;
            }
        }
    }
}
