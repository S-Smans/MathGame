using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Helper
    {
        // Create a class that returns 2 random numbers in an array
        internal int[] GetTwoNumbers()
        {
            Random random = new Random();
            int first = random.Next(1, 10);
            int second = random.Next(1, 10);

            return new int[] { first, second };
        }

        internal int VerifyResultsInput()
        {
            string input = Console.ReadLine();
            while (string.IsNullOrEmpty(input) || !int.TryParse(input, out int result))
            {
                Console.WriteLine(input.GetType().Name);
                Console.WriteLine("Input has to be a number");
                input = Console.ReadLine();
            }

            return int.Parse(input);
        }

        internal int[] GetDivisionNumbers()
        {
            Random random = new Random();
            int first = random.Next(2, 101);
            int second = random.Next(2, 101);

            while (first % second != 0)
            {
                first = random.Next(2, 101);
                second = random.Next(2, 101);
            }

            return new int[] { first, second };
        }
    }
}
