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

        public WolverineProjectileCollisionHandler(CollisionData collision)
        {

        }

        public void HandleCollision()
        {
            if (!enemy.IsHit && !projectile.IsHostile())
            {
                SoundEffectManager.StompEffect();
                enemy.Hit();
                projectile.Explode();
            }
        }
    }
}
