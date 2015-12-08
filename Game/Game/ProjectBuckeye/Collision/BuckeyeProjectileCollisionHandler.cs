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

        public BuckeyeProjectileCollisionHandler(CollisionData collision)
        {

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
