using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {

        Console.WriteLine($"Máximo valor int: {int.MaxValue}");
        Console.WriteLine($"Mínimo valor int: {int.MinValue}");

        Console.WriteLine($"Máximo valor long: {long.MaxValue}");
        Console.WriteLine($"Mínimo valor long: {long.MinValue}");

        Console.WriteLine($"Máximo valor float: {float.MaxValue}");
        Console.WriteLine($"Mínimo valor float: {float.MinValue}");

        Console.WriteLine($"Máximo valor double: {double.MaxValue}");
        Console.WriteLine($"Mínimo valor double: {double.MinValue}");

        Console.WriteLine($"Máximo valor decimal: {decimal.MaxValue}");
        Console.WriteLine($"Mínimo valor decimal: {decimal.MinValue}");

        Console.WriteLine($"Positivo infinito para float: {float.PositiveInfinity}");
        Console.WriteLine($"Negativo infinito para float: {float.NegativeInfinity}");
        Console.WriteLine($"NaN para float: {float.NaN}");

        Console.WriteLine($"Positivo infinito para double: {double.PositiveInfinity}");
        Console.WriteLine($"Negativo infinito para double: {double.NegativeInfinity}");
        Console.WriteLine($"NaN para double: {double.NaN}");

        // -------------------------------------------

        uint a = uint.MaxValue;
        Console.WriteLine($"Valor máximo de uint: {a}");
        uint overflowResult = a + 1;
        Console.WriteLine($"Resultado do overflow em uint (max + 1): {overflowResult}");



        }
    }
}
