
namespace Logica.clases
{
    public class Prestamo
    {
        public int Id;
        public decimal Monto;
        public int Meses;
        public decimal Interes;
        public DateTime FechaPrestamo;
        public bool Garantia;

        public Prestamo(int id, decimal monto, int meses, decimal interes, DateTime fechaPrestamo, bool garantia)
        {
            Id = id;
            Monto = monto;
            Meses = meses;
            Interes = interes;
            FechaPrestamo = fechaPrestamo;
            Garantia = garantia;
        }

        //        Todo
       
        //        El monto del préstamo no puede ser mayor a 4 veces el sueldo del cliente.
        //        El préstamo solo se otorga si el cliente tiene una garantía.
        //        El préstamo se calcula con un interés dependiendo de la duración del mismo(10% para 1-3 meses, 8% para 4-6 meses, 7% para 7-12 meses, 5% para más de 12 meses).
        //        El monto total que debe pagar el cliente es la suma del monto del préstamo + el interés.
    }
}
