using System;

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
    }
}
