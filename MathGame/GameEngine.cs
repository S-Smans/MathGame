using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace MathGame
{
    internal class GameEngine
    {
        private Helper helper;

        public GameEngine(Helper helper) 
        {
            this.helper = helper;
        }
        internal void Addition()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int score = 0;
            for (int i = 0; i < helper.ask; i++)
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
            stopWatch.Stop();
            TimeSpan time = stopWatch.Elapsed;
            string duration = time.ToString("mm':'ss");

            Console.WriteLine($"Your score is: {score} in {duration}");
            helper.AddHistory(GameType.Addition, score, (Difficulty)helper.lvl, duration, helper.ask);
            Console.ReadLine();
        }
        internal void Subtraction()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int score = 0;
            for (int i = 0; i < helper.ask; i++)
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
            stopWatch.Stop();
            TimeSpan time = stopWatch.Elapsed;
            string duration = time.ToString("mm':'ss");

            Console.WriteLine($"Your score is: {score} in {duration}");
            helper.AddHistory(GameType.Subtraction, score, (Difficulty)helper.lvl, duration, helper.ask);
            Console.ReadLine();
        }

        internal void Multiplication()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int score = 0;
            for (int i = 0; i < helper.ask; i++)
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
            stopWatch.Stop();
            TimeSpan time = stopWatch.Elapsed;
            string duration = time.ToString("mm':'ss");

            Console.WriteLine($"Your score is: {score} in {duration}");
            helper.AddHistory(GameType.Multiplication, score, (Difficulty)helper.lvl, duration, helper.ask);
            Console.ReadLine();
        }

        internal void Division()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int score = 0;
            for (int i = 0; i < helper.ask; i++)
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
            stopWatch.Stop();
            TimeSpan time = stopWatch.Elapsed;
            string duration = time.ToString("mm':'ss");

            Console.WriteLine($"Your score is: {score} in {duration}");
            helper.AddHistory(GameType.Division, score, (Difficulty)helper.lvl, duration, helper.ask);
            Console.ReadLine();
        }
    }
}
