using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities
{
    public static class LifeManager
    {
        private static int lives = 3;

        public static void IncrementLives()
        {
            lives += 1;
        }

        public static void DecrementLives()
        {
            lives -= 1;
        }

        public static int Lives
        {
            get { return lives; }
            set { lives = value; }
        }
    }
}
