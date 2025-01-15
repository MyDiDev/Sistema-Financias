using Datos.data;
using System;

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


        Data data = new Data();

        public decimal CalcInteres()
        {
            decimal TasaInteres = -1;
            if (Meses <= 3)
                TasaInteres = 0.10M;
            else if (Meses >= 4 || Meses <= 6)
                TasaInteres = 0.08M;
            else if (Meses >= 7 || Meses <= 12)
                TasaInteres = 0.07M;
            else
                TasaInteres = 0.05M;

            return TasaInteres;
        }

        //public decimal CalcCouta(double tasaAnual, int plazoMeses)
        //{
        //    double i = tasaAnual / 12;

        //    decimal r = CalcInteres();
        //    double couta = Monto * (i * Math.Pow(1 + i, plazoMeses) / Math.Pow(1 + i, plazoMeses) - 1);

        //    return (decimal)couta;
        //}

        public decimal CalcInteresCompuesto()
        {
            double r = (double)CalcInteres();
            int t = Meses / 12;
            int n = 12;


            double InteresCompuesto = Monto * Math.Pow(1 + (r / n), n * t);
            return (decimal)InteresCompuesto;
        }

        public bool RealizarPrestamo(string emailCliente, string tipoInteres, decimal salario,  decimal montoAnterior, decimal montoAbonado, int mora)
        {
            if ((decimal)Monto > (salario * 4) || !Garantia)
            {
                return false;
            }
            else
            {
                decimal Interes = -1;
                decimal r = 0m;

                switch (tipoInteres)
                {
                    case "simple":
                        r = CalcInteres();
                        break;
                    case "compuesto":
                        r = CalcInteresCompuesto();
                        break;
                }

                decimal newAmount = montoAbonado - (decimal)Monto;



                return data.MakeLoan(emailCliente, Monto, Meses, (double)r, FechaPrestamo, Garantia)  && data.MakeAm(emailCliente, montoAbonado, montoAnterior, newAmount, mora);
            }
        }
    }
}
