using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace MathGame
{
    internal class GameEngine
    {
        private Helper helper = new Helper();

        internal void Addition()
        {
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Addition");

                int[] numbers = helper.GetTwoNumbers();
                Console.WriteLine($"{numbers[0]} + {numbers[1]}");
                int userInput = helper.VerifyResultsInput();

                if (userInput == numbers[0] + numbers[1])
                {
                    Console.WriteLine("Correct!");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("WRONG!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("Your score is: " + score);
            helper.AddHistory(GameType.Addition, score);
            Console.ReadLine();
        }
        internal void Subtraction()
        {
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Subtraction");

                int[] numbers = helper.GetTwoNumbers();
                Console.WriteLine($"{numbers[0]} - {numbers[1]}");
                int userInput = helper.VerifyResultsInput();

                if (userInput == numbers[0] - numbers[1])
                {
                    Console.WriteLine("Correct!");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("WRONG!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("Your score is: " + score);
            helper.AddHistory(GameType.Subtraction, score);
            Console.ReadLine();
        }

        internal void Multiplication()
        {
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Multiplication");

                int[] numbers = helper.GetTwoNumbers();
                Console.WriteLine($"{numbers[0]} * {numbers[1]}");
                int userInput = helper.VerifyResultsInput();

                if (userInput == numbers[0] * numbers[1])
                {
                    Console.WriteLine("Correct!");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("WRONG!");
                    Console.ReadLine();
                }

            }
            Console.WriteLine("Your score is: " + score);
            helper.AddHistory(GameType.Multiplication, score);
            Console.ReadLine();
        }

        internal void Division()
        {
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Division");

                int[] numbers = helper.GetDivisionNumbers();
                Console.WriteLine($"{numbers[0]} / {numbers[1]}");
                int userInput = helper.VerifyResultsInput();

                if (userInput == numbers[0] / numbers[1])
                {
                    Console.WriteLine("Correct!");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("WRONG!");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("Your score is: " + score);
            helper.AddHistory(GameType.Division, score);
            Console.ReadLine();
        }
    }
}
