using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class GameEngine
    {
        private Helper helper = new Helper();

        internal void Addition()
        {
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
                }
                else
                {
                    Console.WriteLine("WRONG!");
                    Console.ReadLine();
                }
            }
        }
        internal void Subtraction()
        {
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
                }
                else
                {
                    Console.WriteLine("WRONG!");
                    Console.ReadLine();
                }
            }
        }

        internal void Multiplication()
        {
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
            }
                else
            {
                Console.WriteLine("WRONG!");
                Console.ReadLine();
            }
        }
    }

        internal void Division()
        {
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
            }
                else
            {
                Console.WriteLine("WRONG!");
                Console.ReadLine();
            }
        }
    }
    }
}
