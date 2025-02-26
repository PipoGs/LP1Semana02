using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Valores máximos e mínimos dos tipos numéricos
        Console.WriteLine("Valores Máximos e Mínimos:");

        // int
        Console.WriteLine($"Máximo valor int: {int.MaxValue}");
        Console.WriteLine($"Mínimo valor int: {int.MinValue}");

        // long
        Console.WriteLine($"Máximo valor long: {long.MaxValue}");
        Console.WriteLine($"Mínimo valor long: {long.MinValue}");

        // float
        Console.WriteLine($"Máximo valor float: {float.MaxValue}");
        Console.WriteLine($"Mínimo valor float: {float.MinValue}");

        // double
        Console.WriteLine($"Máximo valor double: {double.MaxValue}");
        Console.WriteLine($"Mínimo valor double: {double.MinValue}");

        // decimal
        Console.WriteLine($"Máximo valor decimal: {decimal.MaxValue}");
        Console.WriteLine($"Mínimo valor decimal: {decimal.MinValue}");
        }
    }
}
