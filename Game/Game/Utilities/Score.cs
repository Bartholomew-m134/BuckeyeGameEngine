using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities
{
    public class Score
    {
        public int value;
        public int offset;
        public Vector2 location;
        public int timer;
        public Score(int value, int offset, Vector2 location)
        {
            this.value = value;
            this.offset = offset;
            this.location = location;
            timer = 10;
        }
        public void Update()
        {
            timer--;
        }
    }
}
