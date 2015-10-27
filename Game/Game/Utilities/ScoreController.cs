using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities
{
    public static class ScoreController
    {
        public static int score;
        public static void IncreaseScore(int value)
        {
            score+=value;
        }
        public static void ResetScore()
        {
            score = 0;
        }
    }
}
