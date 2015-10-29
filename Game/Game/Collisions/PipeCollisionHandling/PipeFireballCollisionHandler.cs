using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Projectiles;
using Game.Interfaces;
using Microsoft.Xna.Framework;

namespace Game.Collisions.PipeCollisionHandling
{
    public class PipeFireballCollisionHandler
    {
        private CollisionData collision;
        private IProjectile fireball;
        private ICollisionSide side;

        public PipeFireballCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            this.side = collision.CollisionSide;

            if (collision.GameObjectA is IProjectile)
            {
                fireball = (IProjectile)collision.GameObjectA;
            }
            else
            {
                fireball = (IProjectile)collision.GameObjectB;
                this.side.FlipSide();
            }
        }

        public void HandleCollision()
        {
            collision.ResolveOverlap(fireball, side);

            if (side is TopSideCollision)
                fireball.Bounce();
            else
                fireball.Explode();
        }
    }
}
