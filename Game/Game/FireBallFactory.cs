using Game.Items;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public class FireBallFactory
    {
        Game1 game;

        FireBallFactory(Game1 game)
        {
            this.game = new Game1();
        }

        public void ReleaseRightFireBall(Vector2 location)
        {
            WorldManager.CreateNewObject(new RightFire(game));
        }

        public void ReleaseLeftFireBall(Vector2 location)
        {
            WorldManager.CreateNewObject(new LeftFire(game));
        }
    }
}
