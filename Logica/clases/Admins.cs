using Datos.data;

namespace Logica.clases
{
    public class Admins
    {
        public int Id;
        public string Nombre;
        public string Correo;
        public string Telefono;
        public string Direccion;

        public Admins(int id, string nombre, string correo, string telefono, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
            Direccion = direccion;
        }

        public Admins(string nombre, string correo) 
        {
            Nombre = nombre;
            Correo = correo;
        }

        Data data = new Data();

        public bool CheckAdmin() => data.CheckAdmin(Nombre, Correo);
        public int getAdminID() => data.GetAdminID(Correo);
    }
}
