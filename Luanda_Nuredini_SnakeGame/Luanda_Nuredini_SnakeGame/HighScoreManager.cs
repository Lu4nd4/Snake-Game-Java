using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luanda_Nuredini_SnakeGame
{
    public static class HighScoreManager
    {
        private static List<int> highScores = new List<int>();

        public static List<int> HighScores
        {
            get { return highScores; }
        }

        public static void AddScore(int score)
        {
            highScores.Add(score);
            highScores.Sort((a, b) => b.CompareTo(a));
            highScores = highScores.Take(10).ToList();
        }
    }
}
