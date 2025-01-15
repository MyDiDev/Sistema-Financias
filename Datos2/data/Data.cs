using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Datos.data
{
    public class Data
    {
        public Data() { }

        public string stringConnection = "Data Source=MSI;Initial Catalog=Financias;Integrated Security=True;";

        //ID methods

        public int GetClientID(string clientEmail)
        {
            if (string.IsNullOrEmpty(clientEmail))
            {
                return 0;
            }

            int ClientId = -1;

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT IDCliente FROM Clientes WHERE Correo=@correo;", conn))
                {
                    cmd.Parameters.AddWithValue("@correo", clientEmail);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ClientId = reader.GetInt32(0);
                        }

                        return ClientId;
                    }
                }
            }
        }


        public int GetLoanID(string clientEmail)
        {
            if (string.IsNullOrEmpty(clientEmail))
            {
                return 0;
            }
            int ClientId = GetClientID(clientEmail);
            int LoanID = -1;

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT IDPrestamo FROM Prestamos WHERE IDCliente=@clientID;", conn))
                {
                    cmd.Parameters.AddWithValue("@clientID", ClientId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ClientId = reader.GetInt32(0);
                        }

                        return ClientId;
                    }
                }
            }
        }

        public int GetAdminID(string adminEmail)
        {
            if (string.IsNullOrEmpty(adminEmail))
            {
                return 0;
            }

            int adminId = -1;

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT IDAdministrador FROM Admins WHERE Correo=@correo;", conn))
                {
                    cmd.Parameters.AddWithValue("@correo", adminEmail);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            adminId = reader.GetInt32(0);
                        }

                        return adminId;
                    }
                }
            }
        }

        //Admin Metodos
        public bool CheckAdmin(string adminName, string adminEmail)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Admins WHERE Nombre=@name AND Correo=@email", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", adminName);
                        cmd.Parameters.AddWithValue("@email", adminEmail);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }

                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        

        //Client methods 
        public bool AddCLient(string nombre, string correo, string telefono, string direccion, string garantia, decimal sueldo, int mora)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Clientes (Nombre, Correo, Telefono, Direccion, Sueldo, Garantia, Moras) VALUES (@Nombre, @Correo, @Telefono, @Direccion, @Sueldo, @Moras);", conn);
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
            catch (SqlException e)
            {
                throw e;
            }
        }


        public List<string> GetClientData(string clientEmail)
        {
            try 
            {
                List<string> data = new List<string>();
                int clientId = GetClientID(clientEmail);

                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Clientes WHERE IDCliente=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", clientId);
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                data.Add(reader.GetString(1));
                                data.Add(reader.GetString(2));
                                data.Add(reader.GetString(3));
                                data.Add(reader.GetString(4));
                                data.Add(reader.GetDecimal(5).ToString());
                                data.Add(reader.GetString(6));
                                data.Add(reader.GetInt32(7).ToString());
                            }

                            return data;
                        }
                    }
                } 
                
                        
            }catch (SqlException e) { 
                throw e;
            }
        }


        public bool CheckClient(string clientName, string clientEmail)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Clientes WHERE Nombre=@name AND Correo=@email", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", clientName);
                        cmd.Parameters.AddWithValue("@email", clientEmail);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }

                    }
                }
            }catch (SqlException e)
            {
                throw e;
            }
        }

        public decimal GetSalary(string clientEmail)
        {
            if (string.IsNullOrEmpty(clientEmail))
            {
                return 0;
            }

            decimal Salary = -1;

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Sueldo FROM Clientes WHERE Correo=@correo;", conn))
                {
                    cmd.Parameters.AddWithValue("@correo", clientEmail);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Salary = reader.GetDecimal(0);
                        }

                        return Salary;
                    }
                }
            }
        }


        //Prestamos Methods

        public bool MakeLoan(string clientName, double monto, int meses, double interes, DateTime fechaPrestamo, bool garantia)
        {
            try
            {
                int ClientID = GetClientID(clientName);
                int Garantia = (garantia) ? 1 : 0;

                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Prestamos (IDCliente, Monto, Meses, Interes, FechaPrestamo, Garantia) VALUES (@IDCliente, @Monto, @Meses, @Interes, @FechaPrestamo, @Garantia);", conn))
                    {
                        cmd.Parameters.AddWithValue("@IDCliente", ClientID);
                        cmd.Parameters.AddWithValue("@Monto", monto);
                        cmd.Parameters.AddWithValue("@Meses", meses);
                        cmd.Parameters.AddWithValue("@Interes", interes);
                        cmd.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo);
                        cmd.Parameters.AddWithValue("@Garantia", Garantia);
                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }

            }catch (SqlException e)
            {
                throw e;
            }
        }

        public bool MakeAm(string clientEmail, decimal montoAnterior, decimal montoAbonado, decimal nuevoMonto, int mora)
        {
            try
            {
                int LoanID = GetLoanID(clientEmail);

                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Amortizaciones (IDPrestamo, MontoAnterior, MontoAbonado, NuevoMonto, Mora) VALUES (@IDPrestamo, @MontoAnterior, @MontoAbonado, @NuevoMonto, @Mora);", conn))
                    {
                        cmd.Parameters.AddWithValue("@IDPrestamo", LoanID);
                        cmd.Parameters.AddWithValue("@MontoAnterior", montoAnterior);
                        cmd.Parameters.AddWithValue("@MontoAbonado", montoAbonado);
                        cmd.Parameters.AddWithValue("@NuevoMonto", nuevoMonto);
                        cmd.Parameters.AddWithValue("@Mora", mora);

                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}
