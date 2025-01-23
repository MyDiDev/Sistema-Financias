using Datos.data;
using System;
using System.Collections.Generic;
using System.Data;

namespace Logica.clases
{
    public class Amortizacion
    {
        public int PrestamoId;
        public DateTime FechaPago;
        public int Mes;
        public decimal MontoAnterior;
        public decimal MontoAbonado;
        public decimal NuevoMonto;
        public decimal InteresMora;
        public int Mora;

        public Amortizacion(int prestamoId, DateTime fechaPago, int mes, decimal montoAnterior, decimal montoAbonado, decimal nuevoMonto, decimal interesMora, int mora)
        {
            PrestamoId = prestamoId;
            FechaPago = fechaPago;
            Mes = mes;
            MontoAnterior = montoAnterior;
            MontoAbonado = montoAbonado;
            NuevoMonto = nuevoMonto;
            InteresMora = interesMora;
            Mora = mora;
        }

        public Amortizacion(int prestamoId, int mes)
        {
            Mes = mes;
            PrestamoId = prestamoId;
        }

        public Amortizacion(int prestamoId)
        {
            PrestamoId = prestamoId;
        }

        Data data = new Data();

        public bool RealizarAmortizacion() => data.MakeAm(PrestamoId, Mes, MontoAnterior, MontoAbonado, NuevoMonto, InteresMora, 0);
        public DataTable getAmortizacionData() => data.GetAmData(PrestamoId);
        public decimal getDeposit() => data.GetDepositValue(PrestamoId);
        public decimal getLastSalary() => data.GetLastSalary(PrestamoId, Mes);
        public bool actualizarAmortizacion() => data.UpdateAm(PrestamoId, Mes, MontoAnterior, MontoAbonado, NuevoMonto, InteresMora, Mora);
        public List<string> getAmortizacionId() => data.getAmId();
        public bool registrarAmortizacion() => data.RegisterAmortizacion(PrestamoId, Mes);
    }
}
