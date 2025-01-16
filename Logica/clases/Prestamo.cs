using Datos.data;
using System;
using System.Data;
using System.Data.SqlClient;

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

        public decimal CalcInteres()
        {
            decimal TasaInteres = -1;
            if (Meses <= 3)
                TasaInteres = 0.10M;
            else if (Meses <= 6)
                TasaInteres = 0.08M;
            else if (Meses <= 12)
                TasaInteres = 0.07M;
            else
                TasaInteres = 0.15M;

            return TasaInteres;
        }

        //public decimal CalcCouta(double tasaAnual, int plazoMeses)
        //{
        //    double i = tasaAnual / 12;

        //    decimal r = CalcInteres();
        //    double couta = Monto * (i * Math.Pow(1 + i, plazoMeses) / Math.Pow(1 + i, plazoMeses) - 1);

        //    return (decimal)couta;
        //}

        //public decimal CalcInteresCompuesto()
        //{
        //    double r = (double)CalcInteres();
        //    int t = Meses / 12;
        //    int n = 12;


        //    double InteresCompuesto = Monto * Math.Pow(1 + (r / n), n * t);
        //    return (decimal)InteresCompuesto;
        //}

        public decimal CalcularMontoTotal(decimal salario)
        {
            decimal SalarioMax = 4 * salario;
            decimal interes = SalarioMax * CalcInteres();
            decimal MontoTotal = SalarioMax + interes;
            return MontoTotal;
        }

        public int getLoanId() => data.GetLoanID(Id);

        public bool RealizarPrestamo(string emailCliente, decimal salario,  decimal montoAnterior, decimal montoAbonado, int mora)
        {
            try
            {
                decimal SalarioMax = 4 * salario;
                if (montoAnterior > SalarioMax || !Garantia)
                {
                    return false;
                }

                decimal porcientoInteres = CalcInteres();
                decimal newAmount = montoAnterior - montoAbonado;
                decimal MontoTotal = CalcularMontoTotal(salario);

                bool loanResult = data.MakeLoan(emailCliente, montoAnterior, Meses, (double)porcientoInteres, FechaPrestamo, Garantia);
                bool amortizationResult = data.MakeAm(emailCliente, montoAnterior, montoAbonado, newAmount, mora);

                return loanResult && amortizationResult;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public DataTable getLoanData() => data.GetLoanData(Id);
    }
}
