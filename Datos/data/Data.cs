using Npgsql;

namespace Datos.data
{
    public class Data
    {
        public Data() { }

        public string stringConnection = "Host=localhost;Port=5432;Username=postgres;Database=mydatabase";

        //Client methods 
        public bool AddCLient(string nombre, string correo, string telefono, string direccion, string garantia, decimal sueldo, int mora)
        {
            try
            {
                using (NpgsqlConnection conn = new(stringConnection))
                {
                    NpgsqlCommand cmd = new("INSERT INTO Clientes (Nombre, Correo, Telefono, Direccion, Sueldo, Garantia, Moras) VALUES (@Nombre, @Correo, @Telefono, @Direccion, @Sueldo, @Moras);", conn);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@Direccion", direccion);
                    cmd.Parameters.AddWithValue("@Sueldo", sueldo);
                    cmd.Parameters.AddWithValue("@Garantia", garantia);
                    cmd.Parameters.AddWithValue("@Moras", mora);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (NpgsqlException e)
            {
                throw e;
            }
        }

        public bool MakeLoan()
        {
            return true;
        }


    }
}
