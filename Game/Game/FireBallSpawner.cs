using Game.Projectiles;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public class FireBallSpawner
    {
        private Game1 game;
        private int count;
        private const int MAXCOUNT = 3;

        public FireBallSpawner(Game1 game)
        {
            this.game = game;
        }

        public void ReleaseRightFireBall(Vector2 location)
        {
            if(count < MAXCOUNT)
            {
                RightFire fire = new RightFire(this, game);
                fire.VectorCoordinates = location;
                WorldManager.CreateNewObject(fire);
                count++;
            }
        }

        public void ReleaseLeftFireBall(Vector2 location)
        {
            if (count < MAXCOUNT)
            {
                LeftFire fire = new LeftFire(this, game);
                fire.VectorCoordinates = location;
                WorldManager.CreateNewObject(fire);
                count++;
            }
        }

        public void ReturnFireBall()
        {
            if(count > 0)
                count--;
        }
    }
}
