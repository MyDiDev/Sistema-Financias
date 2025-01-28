using Datos.data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Logica.clases
{
    public class Prestamo
    {
        public int Id;
        public double Monto;
        public int Meses;
        public double Interes;
        public DateTime FechaPrestamo;
        public bool Garantia;

        public Prestamo(int id, double monto, int meses, double interes, DateTime fechaPrestamo, bool garantia)
        {
            Id = id;
            Monto = monto;
            Meses = meses;
            Interes = interes;
            FechaPrestamo = fechaPrestamo;
            Garantia = garantia;
        }

        public Prestamo(int id, int meses, double monto)
        {
            Id = id;
            Monto = monto;
            Meses = meses;
        }

        public Prestamo(int id, int meses)
        {
            Id = id;
            Meses = meses;
        }

        public Prestamo(int id)
        {
            Id = id;
        }

        Data data = new Data();

        public int getLoanId() => data.GetLoanID(Id);

        public decimal CalcInteres()
        {
            decimal TasaInteres = -1;
            if (Meses <= 3)
                TasaInteres = 0.10M;
            else if (Meses <= 6)
                TasaInteres = 0.08M;
            else if (Meses <= 12)
                TasaInteres = 0.07M;
            else if(Meses > 12)
                TasaInteres = 0.05M;

            return TasaInteres;
        }

        public decimal CalcularMontoTotal(decimal salario)
        {
            decimal SalarioMax = 4 * salario;
            return SalarioMax;
        }

        public double CalcularInteresSalario(double monto)
        {
            double Interes = monto * (double)CalcInteres();
            return Interes;
        }

        public decimal CalcularCuotaMensual()
        {
            decimal cuotaMensual = Math.Round((decimal)Monto / Meses); 
            decimal interesCouta = Math.Round(((decimal)Monto * CalcInteres()) / Meses);  
            cuotaMensual += interesCouta;
            return cuotaMensual;
        }

        public DataTable CalcularAmortizacion()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mes", typeof(int)); 
            dt.Columns.Add("FechaPago", typeof(string)); 
            dt.Columns.Add("MontoAnterior", typeof(decimal)); 
            dt.Columns.Add("Deposito", typeof(decimal));
            dt.Columns.Add("NuevoMonto", typeof(decimal));
            //dt.Columns.Add("Interes", typeof(decimal));

            decimal saldoPendiente = (decimal)Monto;
            decimal cuotaMensual = CalcularCuotaMensual();
            bool mora = false;

            for (int mes = 1; mes <= Meses; mes++)
            {
                decimal interesMes = Math.Round(saldoPendiente * (CalcInteres() / 100) / 12); 
                decimal capitalMes = Math.Round(cuotaMensual - interesMes);  
                saldoPendiente -= capitalMes;

                mora = (mes % 12 == 0) ? true : false;

                if (saldoPendiente < 0)
                    saldoPendiente = 0;

                dt.Rows.Add(
                    mes,
                    DateTime.Now.AddMonths(mes - 1),
                    saldoPendiente + capitalMes,
                    cuotaMensual,
                    saldoPendiente
                    //cuotaMensual * CalcInteres() / Meses
                );
            }

            return dt;
        }

        public decimal MontoAnterior;
        public DataTable RecalcularAmortizacion(decimal montoAnterior, int notPayedMonth, decimal depositoMora, decimal deposito, int moras)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mes", typeof(int));
            dt.Columns.Add("FechaPago", typeof(string));
            dt.Columns.Add("MontoAnterior", typeof(decimal));
            dt.Columns.Add("Deposito", typeof(decimal));
            dt.Columns.Add("NuevoMonto", typeof(decimal));
            dt.Columns.Add("Interes", typeof(decimal));
            dt.Columns.Add("InteresMora", typeof(decimal));
            dt.Columns.Add("Mora", typeof(int));

            decimal interes = Math.Round((montoAnterior * CalcInteres()) / Meses);
            decimal couta = Math.Round((montoAnterior / Meses) + interes);
            int mora = moras;
            decimal interesMora = deposito * CalcInteres();

            dt.Rows.Add(
                notPayedMonth,
                DateTime.Now.AddMonths(notPayedMonth),
                montoAnterior,
                0,
                montoAnterior,
                0,
                interesMora,
                1
            );

            decimal newAmount = montoAnterior - depositoMora;
            notPayedMonth += 1;

            dt.Rows.Add(
               notPayedMonth,
               DateTime.Now.AddMonths(notPayedMonth),
               montoAnterior,
               depositoMora,
               newAmount,
               interes,
               0,
               0
            );

            MontoAnterior = newAmount;


            for (int mes = 1; mes <= Meses-1; mes++)
            {
                notPayedMonth += 1;
                decimal nuevoMonto = MontoAnterior - deposito;
                
                if (nuevoMonto < 0)
                    nuevoMonto = 0;

                dt.Rows.Add(
                    notPayedMonth,
                    DateTime.Now.AddMonths(mes - 1),
                    MontoAnterior,
                    couta,
                    nuevoMonto,
                    interes,
                    0,
                    0
                );

                MontoAnterior = nuevoMonto;
            }

            return dt;
        }
        public bool realizarPrestamo(string Estado)
        {
            try
            {
                decimal SalarioMax = 4 * (decimal)Monto;
                if ((decimal)Monto > SalarioMax || !Garantia)
                {
                    return false;
                }

                decimal porcientoInteres = CalcInteres();

                bool loanResult = data.MakeLoan(Id, (decimal)Monto, Meses, (double)porcientoInteres, FechaPrestamo, Garantia, Estado);
                
                return loanResult;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        public bool checkPrestamo() => data.checkPrestamo(Id);
        public DataTable getLoanData() => data.GetLoanData(Id);
        public bool actualizarPrestamo(int id) => data.updatePrestamo(id);
    }
}