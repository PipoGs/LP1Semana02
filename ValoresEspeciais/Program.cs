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
        Console.WriteLine($"Overflow em uint: {overflowResult}");

        float maxFloat = float.MaxValue;
        Console.WriteLine($"Valor máximo de float: {maxFloat}");
        float overflowPositive = maxFloat * 2;
        Console.WriteLine($"Overflow positivo em float: {overflowPositive}");
        float overflowNegative = -maxFloat * 2;
        Console.WriteLine($"Overflow negativo em float {overflowNegative}");

        float b = float.Epsilon;

        Console.WriteLine($"Valor mínimo positivo de float: {b}");
        float underflowPositive = b / 2;
        Console.WriteLine($"Underflow positivo em float: {underflowPositive}");

        float b2 = -b;
        float underflowNegative = b2 / 2;
        Console.WriteLine($"Underflow negativo em float: {underflowNegative}");
    



        }
    }
}
