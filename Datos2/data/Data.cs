using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

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
                            LoanID = reader.GetInt32(0);
                        }

                        return LoanID;
                    }
                }
            }
        }
        
        //overload
        public int GetLoanID(int clientId)
        {
            int LoanID = -1;

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT IDPrestamo FROM Prestamos WHERE IDCliente=@clientID;", conn))
                {
                    cmd.Parameters.AddWithValue("@clientID", clientId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            LoanID = reader.GetInt32(0);
                        }

                        return LoanID;
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

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Clientes (Nombre, Correo, Telefono, Direccion, Sueldo, Garantia, Moras) VALUES (@Nombre, @Correo, @Telefono, @Direccion, @Sueldo, @Garantia, @Moras);", conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@Direccion", direccion);
                        cmd.Parameters.AddWithValue("@Sueldo", sueldo);
                        cmd.Parameters.AddWithValue("@Garantia", garantia);
                        cmd.Parameters.AddWithValue("@Moras", 0);

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

        public bool UpdateClient(int id, string nombre, string correo, string telefono, string direccion, string garantia, decimal sueldo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("UPDATE Clientes SET Nombre=@Nombre, Correo=@Correo, Telefono=@Telefono, Direccion=@Direccion, Sueldo=@Sueldo WHERE IDCliente=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@Direccion", direccion);
                        cmd.Parameters.AddWithValue("@Sueldo", sueldo);
                        
                        int affectedRows = cmd.ExecuteNonQuery();
                        return affectedRows > 0;
                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public List<string> GetClientData(int id)
        {
            try 
            {
                List<string> data = new List<string>();

                int Id = GetLoanID(id);

                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Clientes WHERE IDCliente=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

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
            decimal Salary = -1;

            try
            {
                if (string.IsNullOrEmpty(clientEmail))
                {
                    return 0;
                }


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
            catch (SqlException)
            {
                return 0;
            }
        }

        public bool addMora(int id, int mora)
        {
            try
            {
                int moras = -1;
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Moras FROM Clientes WHERE IDCliente=@id;", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                moras = reader.GetInt32(0);
                            }
                        }
                    }
                    
                    using(SqlCommand cmd = new SqlCommand("UPDATE Clientes SET Moras=@mora WHERE IDCliente=@id;", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@mora", moras+mora);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }catch(SqlException e)
            {
                throw e;
            }
        }

        public List<string> GetCorreo()
        {
            List<string> correo = new List<string>();

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Correo FROM Clientes;", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            correo.Add(reader.GetString(0));
                        }

                        return correo;
                    }
                }
            }
        }

        //Prestamos Methods

        public bool checkPrestamo(int ClientID)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();

                    using(SqlCommand cmd = new SqlCommand("SELECT * FROM Prestamos WHERE IDCliente=@id AND Estado='En Proceso';", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", ClientID);

                        using(SqlDataReader reader = cmd.ExecuteReader())
                 
                        {

                            if (reader.HasRows)
                            {
                                conn.Close();
                                return true;
                            }

                            conn.Close();
                            return false;
                        }
                    }

                }
            }catch(SqlException e)
            {
                throw e;
            }
        }

        public bool MakeLoan(int ClientID, decimal monto, int meses, double interes, DateTime fechaPrestamo, bool garantia, string Estado)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Prestamos (IDCliente, Monto, Meses, Interes, FechaPrestamo, Garantia, Estado) VALUES (@IDCliente, @Monto, @Meses, @Interes, @FechaPrestamo, @Garantia, @Estado);", conn))
                    {
                        cmd.Parameters.AddWithValue("@IDCliente", ClientID);
                        cmd.Parameters.AddWithValue("@Monto", monto);
                        cmd.Parameters.AddWithValue("@Meses", meses);
                        cmd.Parameters.AddWithValue("@Interes", interes);
                        cmd.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo);
                        cmd.Parameters.AddWithValue("@Garantia", 1);
                        cmd.Parameters.AddWithValue("@Estado", Estado);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }

            }catch (SqlException e)
            {
                throw e;
            }
        }

        public DataTable GetLoanData(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Prestamos WHERE IDCliente=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }


            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public DataTable GetAmData(int pId)
        {
            try
            {
                int ID = GetLoanID(pId);

                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Amortizaciones WHERE IDPrestamo=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", pId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public decimal GetLastSalary(int pId, int Month)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT NuevoMonto FROM Amortizaciones WHERE IDPrestamo=@id AND Mes=@mes;", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", pId);
                        cmd.Parameters.AddWithValue("@mes", Month);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader.GetDecimal(0);
                            }

                            return -1;
                        }
                    }    
                }
            }catch(SqlException e)
            {
                throw e;
            }
        }

        public bool MakeAm(int id, int mes, decimal montoAnterior, decimal montoAbonado, decimal nuevoMonto, decimal interesMora, int mora)
        {
            try
            {
               
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Amortizaciones (IDPrestamo, Mes, MontoAnterior, MontoAbonado, NuevoMonto, Mora, InteresMora) VALUES (@IDPrestamo, @Mes, @MontoAnterior, @MontoAbonado, @NuevoMonto, @Mora, @InteresMora);", conn))
                    {
                        cmd.Parameters.Add("@IDPrestamo", SqlDbType.Int).Value = id;
                        cmd.Parameters.Add("@Mes", SqlDbType.Int).Value = mes;
                        cmd.Parameters.Add("@MontoAnterior", SqlDbType.Decimal).Value = montoAnterior;
                        cmd.Parameters.Add("@MontoAbonado", SqlDbType.Decimal).Value = montoAbonado;
                        cmd.Parameters.Add("@NuevoMonto", SqlDbType.Decimal).Value = nuevoMonto;
                        cmd.Parameters.Add("@InteresMora", SqlDbType.Decimal).Value = interesMora;
                        cmd.Parameters.Add("@Mora", SqlDbType.Int).Value = mora;

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

        public List<string> getAmId()
        {
            List<string> id = new List<string>();

            using(SqlConnection conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand("SELECT IDAmortizacion FROM Amortizaciones",conn))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id.Add(reader.GetInt32(0).ToString());
                        }

                        return id;
                    }
                }
            }
        }

        public bool UpdateAm(int id, int mes, decimal montoAnterior, decimal montoAbonado, decimal nuevoMonto, decimal interesMora, int mora)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand("UPDATE Amortizaciones SET MontoAnterior=@MontoAnterior, MontoAbonado=@MontoAbonado, NuevoMonto=@NuevoMonto, Mora=@Mora, InteresMora=@InteresMora WHERE Mes=@Mes AND IDPrestamo=@id;", conn))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        cmd.Parameters.Add("@Mes", SqlDbType.Int).Value = mes;
                        cmd.Parameters.Add("@MontoAnterior", SqlDbType.Decimal).Value = montoAnterior;
                        cmd.Parameters.Add("@MontoAbonado", SqlDbType.Decimal).Value = montoAbonado;
                        cmd.Parameters.Add("@NuevoMonto", SqlDbType.Decimal).Value = nuevoMonto;
                        cmd.Parameters.Add("@InteresMora", SqlDbType.Decimal).Value = interesMora;
                        cmd.Parameters.Add("@Mora", SqlDbType.Int).Value = mora;
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }catch(SqlException e)
            {
                throw e;
            }
        }

        public decimal CalcularCuotaMensual(decimal TasaInteres, decimal Monto, int Meses)
        {
            decimal tasaMensual = TasaInteres / 100 / 12;
            decimal cuotaMensual = Monto * tasaMensual * (decimal)Math.Pow((double)(1 + tasaMensual), Meses) / (decimal)(Math.Pow((double)(1 + tasaMensual), Meses) - 1);
            return cuotaMensual;
        }

        public void CalcularAmortizacion(int id, string clientEmail, decimal TasaInteres, decimal Monto, int Meses)
        {
            int pId = GetLoanID(id);
            decimal saldoPendiente = Monto;
            decimal cuotaMensual = CalcularCuotaMensual(TasaInteres, Monto, Meses);
            int mora = 0;

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                conn.Open();

                for (int mes = 1; mes <= Meses; mes++)
                {
                    decimal interesMes = saldoPendiente * (TasaInteres / 100) / 12;
                    decimal capitalMes = cuotaMensual - interesMes;
                    saldoPendiente -= capitalMes;


                    if (mes % 12 == 0)
                    {
                        mora = 1;
                    }else{
                        mora = 0;
                    }

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Amortizaciones (IDPrestamo, MontoAnterior, MontoAbonado, NuevoMonto, Mora) VALUES (@IDPrestamo, @MontoAnterior, @MontoAbonado, @NuevoMonto, @Mora)", conn))
                    {
                        cmd.Parameters.AddWithValue("@IDPrestamo", pId);
                        cmd.Parameters.AddWithValue("@MontoAnterior", saldoPendiente + capitalMes);
                        cmd.Parameters.AddWithValue("@MontoAbonado", cuotaMensual);
                        cmd.Parameters.AddWithValue("@NuevoMonto", saldoPendiente);
                        cmd.Parameters.AddWithValue("@Mora", mora);

                        cmd.ExecuteNonQuery();
                    }
                }

                conn.Close();
            }
        }
    
        public decimal GetDepositValue(int id)
        {
            decimal depositValue = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT MontoAbonado FROM Amortizaciones WHERE IDPrestamo=@id;", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                depositValue = reader.GetDecimal(0);
                            }

                            return depositValue;
                        }
                    }
                }
            }catch(SqlException e)
            {
                throw e;
            }
        }

        public bool RegisterAmortizacion(int id, int mes)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand("DELETE FROM Amortizaciones WHERE IDPrestamo=@id AND Mes=@mes;", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@mes", mes);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }catch(SqlException e)
            {
                throw e;
            }
        }
    }
}
