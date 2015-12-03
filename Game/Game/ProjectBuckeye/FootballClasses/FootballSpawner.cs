using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Game.ProjectBuckeye.FootballClasses;

namespace Game.ProjectBuckeye.FootballClasses
{
    public class FootballSpawner
    {
        private Game1 game;
        private int count;
        private const int MAXCOUNT = 2;

        public FootballSpawner(Game1 game)
        {
            this.game = game;
        }

        public void ReleaseFootball(Vector2 location, bool lookingRight)
        {
            if (count < MAXCOUNT)
            {
                Football football = new Football(this, game, lookingRight);
                football.VectorCoordinates = new Vector2(location.X, location.Y + 10);
                WorldManager.CreateNewObject(football);
                count++;
            }
        }

        public void ReturnFootball()
        {
            if (count > 0)
                count--;
        }
    }
}
