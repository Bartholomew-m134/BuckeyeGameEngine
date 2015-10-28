using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Projectiles;
using Game.Interfaces;
using Microsoft.Xna.Framework;

namespace Game.Collisions.BlockCollisionHandling
{
    public class BlockFireballCollisionHandler
    {
        private CollisionData collision;
        private IProjectile fireball;
        private ICollisionSide side;

        public BlockFireballCollisionHandler(CollisionData collision)
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
            {
                collision.ResolveOverlap(fireball, side);
                fireball.Physics.Velocity = new Vector2(fireball.Physics.Velocity.X, -5);
            }
            else
            {
                fireball.Explode();
            }
        }
    }
}
