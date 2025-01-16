using Datos.data;
using System;
using System.Data;
using System.Runtime.Remoting.Messaging;

namespace Logica.clases
{
    public class Amortizacion
    {
        public int PrestamoId;
        public DateTime FechaPago;
        public decimal MontoAnterior;
        public decimal MontoAbonado;
        public decimal NuevoMonto;
        public bool Mora;

        public Amortizacion(int prestamoId, DateTime fechaPago, decimal montoAnterior, decimal montoAbonado, decimal nuevoMonto, bool mora)
        {
            PrestamoId = prestamoId;
            FechaPago = fechaPago;
            MontoAnterior = montoAnterior;
            MontoAbonado = montoAbonado;
            NuevoMonto = nuevoMonto;
            Mora = mora;
        }

        public Amortizacion(int prestamoId)
        {
            PrestamoId = prestamoId;
        }

            Data data = new Data();

        public bool RealizarAmortizacion(string clientEmail) => data.MakeAm(clientEmail, MontoAnterior, MontoAbonado, NuevoMonto, PrestamoId);
        public DataTable getAmortizacionData() => data.GetAmData(PrestamoId);
    }
}
