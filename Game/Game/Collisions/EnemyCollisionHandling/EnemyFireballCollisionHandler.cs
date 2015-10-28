using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Projectiles;
using Game.Interfaces;

namespace Game.Collisions.EnemyCollisionHandling
{
    public class EnemyFireballCollisionHandler
    {
        private IEnemy enemy;
        private IProjectile fireball;
        private CollisionData collision;

        public EnemyFireballCollisionHandler(CollisionData collision)
        {
            this.collision = collision;

            if (collision.GameObjectA is IEnemy)
            {
                enemy = (IEnemy)collision.GameObjectA;
                fireball = (IProjectile)collision.GameObjectB;
            }
            else
            {
                enemy = (IEnemy)collision.GameObjectB;
                fireball = (IProjectile)collision.GameObjectA;
            }
        }

        public void HandleCollision()
        {
            enemy.CanDealDamage = false;
            enemy.Flipped();
        }
    }
}
