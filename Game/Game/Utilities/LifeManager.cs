﻿using System;
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
            // John, I created this skeleton so that I could implement coin/life increment
            // without the game crashing. On my end, this method is called every time 100 
            // coins are accumulated or when a life is awarded in a stomp/shell sequence.
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
