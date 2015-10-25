using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Enemies;
using Game.Enemies.GoombaClasses;
using Game.Enemies.KoopaClasses;
using Game.Interfaces;

namespace Game.Collisions.EnemyCollisionHandling
{
    public class MarioEnemyCollisionHandler
    {
        private IMario mario;
        private IEnemy enemy;
        private ICollisionSide side;
        private CollisionData collision;
        public MarioEnemyCollisionHandler(CollisionData collision)
        {
            this.collision = collision;

            side = collision.CollisionSide;
            if (collision.GameObjectA is IMario)
            {
                mario = (IMario)collision.GameObjectA;
                enemy = (IEnemy)collision.GameObjectB;
            }
            else
            {
                mario = (IMario)collision.GameObjectB;
                enemy = (IEnemy)collision.GameObjectA;
                side = side.FlipSide();
            }
        }

        public void HandleCollision()
        {
            if(enemy.CanDealDamage)
                collision.ResolveOverlap(mario, side);

            if (!mario.IsStar() && side is TopSideCollision)
            {
                enemy.CanDealDamage = false;
                enemy.IsHit();
            }
            else if(!mario.IsStar())
            {
                if (enemy.CanDealDamage)
                {
                    mario.Damage();
                }
            }
            else
            {
                enemy.CanDealDamage = false;
                enemy.Flipped();
            }
        }
    }
}
