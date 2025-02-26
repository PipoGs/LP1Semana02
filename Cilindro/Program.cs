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

            int n = int.Parse(input);
            int n2 = int.Parse(input2);
            float pi = MathF.PI;


            float V = n * (n2 * n2) * pi;
            string limit = $"{V:f3}";

            
            Console.WriteLine(limit);
        }
    }
}
