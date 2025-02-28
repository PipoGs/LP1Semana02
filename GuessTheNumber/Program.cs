using System;
using System.Formats.Asn1;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Random rnd = new Random();
                int numberToGuess = rnd.Next(31);

                string question;

                Console.Write(" Write a whole number from 0 to 30: ");
                question = Console.ReadLine();

                int QuestionC = int.Parse(question);

                if (QuestionC > 30)
                {
                    Console.Write("Out of Scope, Try again,");
                }

                else if (QuestionC < 0)
                {
                    Console.Write("Out of Scope, Try again,");
                }

                else if (QuestionC > numberToGuess)
                {
                    Console.Write("The number you wrote is higher than the Number to guess, Try again, ");
                }

                else if (QuestionC > numberToGuess)
                {
                    Console.Write("The number you wrote is lower than the Number to guess, Try again, ");
                }







            }


        }

    }
}
