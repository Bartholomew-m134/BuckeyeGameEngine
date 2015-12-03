using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Collisions;
using Game.SoundEffects;

namespace Game.ProjectBuckeye.Collision
{
    public class WolverineProjectileCollisionHandler
    {
        private IWolverine enemy;
        private IProjectile projectile;
        private ICollisionSide collisionSide;
        private CollisionData collision;

        public WolverineProjectileCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            collisionSide = (ICollisionSide)collision.CollisionSide;
            if (collision.GameObjectA is IWolverine)
            {
                enemy = (IWolverine)collision.GameObjectA;
                projectile = (IProjectile)collision.GameObjectB;
            }
            else
            {
                enemy = (IWolverine)collision.GameObjectB;
                projectile = (IProjectile)collision.GameObjectA;
                collisionSide = collisionSide.FlipSide();
            }
        }

        public void HandleCollision()
        {
            SoundEffectManager.StompEffect();
            if (!enemy.IsHit)
            {
                enemy.Hit();
                projectile.Explode();
            }
        }
    }
}
