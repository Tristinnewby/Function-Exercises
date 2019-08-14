using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Exercises
{
    class Program
    {
        static void Main()
        {
            Game game = new Game();
            game.score = 100;
            game.Start();
            Console.Read();
        }
    }

    class Game
    {
        public int score = 0;

        public void Start()
        {
            ChangeScore(5);
            PrintScore();
            ChangeScore(2);
            PrintScore();
            ChangeScore(12);
            PrintScore();
            ChangeScore(8);
            PrintScore();
        }

        public int ChangeScore(int val)
        {
            score += val;
            return score;
        }

        public void PrintScore()
        {
            Console.WriteLine("Score: " + score);
        }
    }
}
