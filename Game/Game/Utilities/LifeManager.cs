using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities
{
    public static class LifeManager
    {
        private static int lives;

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
    }
}
