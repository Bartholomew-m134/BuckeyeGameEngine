using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;

namespace Game.Utilities
{
    public static class LifeManager
    {
        private static int lives = LifeConstants.INITIALLIVES;

        public static void IncrementLives()
        {
            lives++;
        }

        public static void DecrementLives()
        {
            lives--;
        }

        public static int Lives
        {
            get { return lives; }
            set { lives = value; }
        }

        public static void ResetLives()
        {
            lives = LifeConstants.INITIALLIVES;
        }
    }
}
