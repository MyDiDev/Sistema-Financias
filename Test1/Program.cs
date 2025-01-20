using System;
using System.Collections.Generic;

public class Cliente
{
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public decimal Sueldo { get; set; }
    public string Garantia { get; set; }

    // Constructor
    public Cliente(string nombre, string email, string telefono, string direccion, decimal sueldo, string garantia)
    {
        Nombre = nombre;
        Email = email;
        Telefono = telefono;
        Direccion = direccion;
        Sueldo = sueldo;
        Garantia = garantia;
    }
}

public class Prestamo
{
    public decimal Monto { get; set; }
    public int Meses { get; set; }
    public decimal TasaInteres { get; set; }  // Tasa anual
    public decimal MontoTotal { get; set; }

    // Constructor
    public Prestamo(decimal monto, int meses, decimal tasaInteres)
    {
        Monto = monto;
        Meses = meses;
        TasaInteres = tasaInteres;
        MontoTotal = CalcularMontoTotal();
    }

    public decimal CalcularMontoTotal()
    {
        decimal interes = Monto * TasaInteres * Meses / 100;
        return Monto + interes;
    }

    public List<Amortizacion> CalcularAmortizacion()
    {
        List<Amortizacion> amortizaciones = new List<Amortizacion>();
        decimal saldoPendiente = Monto;
        decimal cuotaMensual = CalcularCuotaMensual();

        for (int i = 1; i <= Meses; i++)
        {
            decimal interesMes = saldoPendiente * (TasaInteres / 100) / 12;
            decimal capitalMes = cuotaMensual - interesMes;
            saldoPendiente -= capitalMes;

            amortizaciones.Add(new Amortizacion(i, cuotaMensual, interesMes, capitalMes, saldoPendiente));
        }

        return amortizaciones;
    }

    public decimal CalcularCuotaMensual()
    {
        decimal r = TasaInteres / 100 / 12;
        return Monto * r * (decimal)Math.Pow(1 + (double)r, Meses) / (decimal)(Math.Pow(1 + (double)r, Meses) - 1);
    }
}

public class Amortizacion
{
    public int Mes { get; set; }
    public decimal CuotaMensual { get; set; }
    public decimal Interes { get; set; }
    public decimal Capital { get; set; }
    public decimal SaldoPendiente { get; set; }

    // Constructor
    public Amortizacion(int mes, decimal cuotaMensual, decimal interes, decimal capital, decimal saldoPendiente)
    {
        Mes = mes;
        CuotaMensual = cuotaMensual;
        Interes = interes;
        Capital = capital;
        SaldoPendiente = saldoPendiente;
    }
}

// Ejemplo de uso
class Program
{
    static void Main(string[] args)
    {
        // Crear un cliente
        Cliente cliente = new Cliente("Juan Perez", "juanperez@example.com", "555-1234", "Calle Falsa 123", 30000, "Casa");

        // Crear un préstamo
        Prestamo prestamo = new Prestamo(100000, 12, 8);

        // Calcular la amortización
        var amortizaciones = prestamo.CalcularAmortizacion();

        // Mostrar los resultados
        foreach (var amort in amortizaciones)
        {
            Console.WriteLine($"Mes {amort.Mes}: Cuota = {amort.CuotaMensual}, Interés = {amort.Interes}, Capital = {amort.Capital}, Saldo Pendiente = {amort.SaldoPendiente}");
        }
    }
}
