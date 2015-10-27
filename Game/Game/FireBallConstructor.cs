using Game.Items;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public static class FireBallConstructor
    {
        public static void ReleaseRightFireBall(Vector2 location, Game1 game)
        {
            WorldManager.CreateNewObject(new RightFire(game));
        }

        public static void ReleaseLeftFireBall(Vector2 location, Game1 game)
        {
            WorldManager.CreateNewObject(new LeftFire(game));
        }
    }
}
