using System;
using System.Formats.Asn1;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberToGuess = rnd.Next(31);

            int turn = 0;

            while (true)
            {

                turn++;

                string question;

                Console.Write("Insert Number: ");
                question = Console.ReadLine();

                int QuestionC = int.Parse(question);

                if (QuestionC > 30)
                {
                    Console.WriteLine("Numbers must be between 0 and 30. Try again.");
                    continue;
                }

                else if (QuestionC < 0)
                {
                    Console.WriteLine("Numbers must be between 0 and 30. Try again.");
                    continue;
                }

                else if (QuestionC < numberToGuess)
                {
                    Console.WriteLine($"The hidden number is higher than {QuestionC}. Try Again");
                    continue;
                }

                else if (QuestionC > numberToGuess)
                {
                    Console.WriteLine($"The hidden number is lower than {QuestionC}. Try Again");
                    continue;
                }

                else if (QuestionC == numberToGuess)
                {
                    Console.WriteLine($"You found tge hidden number {QuestionC} after {turn} tries.");
                    continue;
                }

                else
                {
                    break;
                }
                







            }


        }

    }
}
