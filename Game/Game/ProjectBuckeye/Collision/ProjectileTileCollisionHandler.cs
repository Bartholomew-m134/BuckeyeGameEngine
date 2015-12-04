using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Collisions;
using Game.SoundEffects;

namespace Game.ProjectBuckeye.Collision
{
    public class ProjectileTileCollisionHandler
    {
        private IProjectile projectile;

        public ProjectileTileCollisionHandler(CollisionData collision)
        {
            if (collision.GameObjectA is IProjectile)
            {
                projectile = (IProjectile)collision.GameObjectA;
            }
            else
            {
                projectile = (IProjectile)collision.GameObjectB;
            }
        }

        public void HandleCollision()
        {
            SoundEffectManager.StompEffect();
            projectile.Explode();
        }
    }
}
