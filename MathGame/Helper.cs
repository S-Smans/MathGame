using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Helper
    {
        private List<Game> games = new List<Game>();
        public int lvl = 1;
        // Create a class that returns 2 random numbers in an array
        internal int[] GetTwoNumbers()
        {
            Random random = new Random();
            int first = random.Next(1, 10 * lvl);
            int second = random.Next(1, 10 * lvl);

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
            int first = random.Next(2, 101 * lvl);
            int second = random.Next(2, 101 * lvl);

            while (first % second != 0)
            {
                first = random.Next(2, 101 * lvl);
                second = random.Next(2, 101 * lvl);
            }

            return new int[] { first, second };
        }


        internal void History()
        {
            foreach (Game game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts on {game.Level}");
            }
            Console.ReadLine();
        }

        internal void AddHistory(GameType type, int score, Difficulty level)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = score,
                Type = type,
                Level = level
            });
        }

        internal void ChangeDifficulty()
        {
            lvl++;
            if (lvl > 3)
            {
                lvl = 1;
            }
        }
    }
}
