using Datos.data;

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
        public decimal Sueldo;
        public int Moras;

        public Cliente(string nombre, string correo, string telefono, string direccion, string garantia, decimal sueldo, int moras)
        {
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
            Direccion = direccion;
            Garantia = garantia;
            Sueldo = sueldo;
            Moras = moras;
        }

        Data datos = new();

        public bool addClient() => datos.AddCLient(Nombre, Correo, Telefono, Direccion, Garantia, Sueldo, Moras);
        public bool makeLoan() => datos.MakeLoan();
    }
}
