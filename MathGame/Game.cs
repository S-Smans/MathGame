using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Game
    {
        public DateTime Date { get; set; }
        public int Score { get; set; }
        public GameType Type { get; set; }
        public Difficulty Level { get; set; }
    }

    internal enum GameType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
    }

    internal enum Difficulty
    {
        Easy = 1,
        Medium,
        Hard
    }
}
