using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Collisions;
using Game.SoundEffects;

namespace Game.ProjectBuckeye.Collision
{
    public class BuckeyeProjectileCollisionHandler
    {
        private IBuckeyePlayer player;
        private IProjectile projectile;
        private ICollisionSide collisionSide;
        private CollisionData collision;

        public BuckeyeProjectileCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            collisionSide = (ICollisionSide)collision.CollisionSide;
            if (collision.GameObjectA is IBuckeyePlayer)
            {
                player = (IBuckeyePlayer)collision.GameObjectA;
                projectile = (IProjectile)collision.GameObjectB;
            }
            else
            {
                player = (IBuckeyePlayer)collision.GameObjectB;
                projectile = (IProjectile)collision.GameObjectA;
                collisionSide = collisionSide.FlipSide();
            }
        }

        public void HandleCollision()
        {
            if (!player.IsDead && projectile.IsHostile())
            {
                SoundEffectManager.StompEffect();
                player.Damage();
                projectile.Explode();
            }
        }
    }
}
