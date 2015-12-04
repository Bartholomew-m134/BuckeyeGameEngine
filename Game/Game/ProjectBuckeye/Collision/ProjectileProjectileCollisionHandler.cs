using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Collisions;
using Game.SoundEffects;

namespace Game.ProjectBuckeye.Collision
{
    public class ProjectileProjectileCollisionHandler
    {
        private CollisionData collision;
        public ProjectileProjectileCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
        }

        public void HandleCollision()
        {
            SoundEffectManager.StompEffect();
            ((IProjectile)(collision.GameObjectA)).Explode();
            ((IProjectile)(collision.GameObjectB)).Explode();
        }
    }
}
