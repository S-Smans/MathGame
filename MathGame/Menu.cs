using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Menu
    {
        internal void StartGame()
        {
            bool gameInProcess = true;

            do
            {
                Console.Clear();
                PrintIntroduction();

                string userInput = Console.ReadLine();

                switch (userInput.Trim().ToUpper())
                {
                    case "A":
                        Console.WriteLine("Addition");
                        Console.ReadLine();
                        break;
                    case "S":
                        Console.WriteLine("Subtraction");
                        Console.ReadLine();
                        break;
                    case "M":
                        Console.WriteLine("Multiplication");
                        Console.ReadLine();
                        break;
                    case "D":
                        Console.WriteLine("Division");
                        Console.ReadLine();
                        break;
                    case "Q":
                        Console.WriteLine("Goodbye!");
                        gameInProcess = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.ReadLine();
                        break;
                }
            } while (gameInProcess);

        }

        private void PrintIntroduction()
        {
            Console.WriteLine("Welcome to the Math Game! Where your knowledge in mathematics will be tested");
            Console.WriteLine("Choose from the options below which math operand you want to test your skills with:");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("A - Addition");
            Console.WriteLine("S - Subraction");
            Console.WriteLine("M - Multiplication");
            Console.WriteLine("D - Division");
            Console.WriteLine("Q - Quit");
            Console.WriteLine();
        }
    }
}
