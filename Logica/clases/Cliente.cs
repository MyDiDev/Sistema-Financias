using Datos.data;
using System.Collections.Generic;

namespace Logica.clases
{
    public class Cliente
    {
        public int Id;
        public string Nombre;
        public string Correo;
        public string Telefono;
        public string Direccion;
        public string Garantia;
        public double Sueldo;
        public int Moras;

        public Cliente(string nombre, string correo, string telefono, string direccion, string garantia, double sueldo, int moras)
        {
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
            Direccion = direccion;
            Garantia = garantia;
            Sueldo = sueldo;
            Moras = moras;
        }


        public Cliente(string nombre, string correo, string telefono, string direccion, double sueldo, string garantia)
        {
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
            Direccion = direccion;
            Sueldo = sueldo;
            Garantia = garantia;
        }

        public Cliente(string nombre, string correo)
        {
            Nombre = nombre;
            Correo = correo;
        }

        public Cliente(string nombre)
        {
            Nombre = nombre;
        }

        public Cliente(int id)
        {
            Id = id;
        }

        Data datos = new Data();

        public bool addClient() => datos.AddCLient(Nombre, Correo, Telefono, Direccion, Garantia, (decimal)Sueldo, Moras);
        public bool updateClient(int id) => datos.UpdateClient(id, Nombre, Correo, Telefono, Direccion, Garantia, (decimal)Sueldo);
        public List<string> getData() => datos.GetClientData(Id);
        public decimal getSalary() => datos.GetSalary(Correo);
        public bool checkClient() => datos.CheckClient(Nombre, Correo);
        public int getId() => datos.GetClientID(Correo);
        public bool agregarMora(int mora) => datos.addMora(Id, mora);

        //public bool makeLoan() => datos.MakeLoan();
    }
}
