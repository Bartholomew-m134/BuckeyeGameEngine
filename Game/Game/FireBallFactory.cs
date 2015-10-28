using Game.Projectiles;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public class FireBallFactory
    {
        private Game1 game;

        public FireBallFactory(Game1 game)
        {
            this.game = game;
        }

        public void ReleaseRightFireBall(Vector2 location)
        {
            RightFire fire = new RightFire(game);
            fire.VectorCoordinates = location;
            WorldManager.CreateNewObject(fire);
        }

        public void ReleaseLeftFireBall(Vector2 location)
        {
            LeftFire fire = new LeftFire(game);
            fire.VectorCoordinates = location;
            WorldManager.CreateNewObject(fire);
        }
    }
}
