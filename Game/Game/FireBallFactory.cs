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
        private static int count;

        public FireBallFactory(Game1 game)
        {
            this.game = game;
        }

        public void ReleaseRightFireBall(Vector2 location)
        {
            Console.WriteLine("FireBall " + count);
            if(count < 5)
            {
            RightFire fire = new RightFire(this, game);
            fire.VectorCoordinates = location;
            WorldManager.CreateNewObject(fire);
            count++;
            }
        }

        public void ReleaseLeftFireBall(Vector2 location)
        {
            if (count < 5)
            {
                LeftFire fire = new LeftFire(this, game);
                fire.VectorCoordinates = location;
                WorldManager.CreateNewObject(fire);
                count++;
            }
        }

        public void ReturnFireBall()
        {
            count--;
        }
    }
}
