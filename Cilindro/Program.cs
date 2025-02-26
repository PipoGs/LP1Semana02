using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere a Altura do Cilindro: ");
            string input = Console.ReadLine();
            Console.WriteLine("Insere o Raio do Cilindro: ");
            string input2 = Console.ReadLine();

            double n = double.Parse(input);
            double n2 = double.Parse(input2);
            double pi = Math.PI;
            double n3 = 2;


            double V = n * (n2 * n2) * pi;
            string limit = $"{V:f3}";

            double S = n3 * pi * n2 * (n2 + n);
            string limit2 = $"{S:f3}";

            
            Console.WriteLine(limit);
            Console.WriteLine(limit2);
        }
    }
}
