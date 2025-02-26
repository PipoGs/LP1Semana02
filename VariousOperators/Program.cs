using System;
using System.Security.Cryptography.X509Certificates;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere número inteiro-não negativo:");
            string input = Console.ReadLine();
            sbyte n = sbyte.Parse(input);
              
    

            Console.WriteLine(n/2);
            Console.WriteLine(n<<3);
            Console.WriteLine(n^6);
            Console.WriteLine(n>10);

        }
    }
}
