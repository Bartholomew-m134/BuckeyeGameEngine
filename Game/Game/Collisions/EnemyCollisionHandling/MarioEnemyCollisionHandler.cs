using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Enemies;
using Game.Enemies.GoombaClasses;
using Game.Enemies.KoopaClasses;
using System.Diagnostics;

namespace Game.Collisions.EnemyCollisionHandling
{
    public class MarioEnemyCollisionHandler
    {
        private MarioInstance mario;
        private IEnemy enemy;
        private ICollisionSide side;
        private CollisionData collision;
        public MarioEnemyCollisionHandler(CollisionData collision)
        {
            this.collision = collision;

            side = collision.collisionSide;
            if (collision.gameObjectA is IMario)
            {
                mario = (MarioInstance)collision.gameObjectA;
                enemy = (IEnemy)collision.gameObjectB;
            }
            else
            {
                mario = (MarioInstance)collision.gameObjectB;
                enemy = (IEnemy)collision.gameObjectA;
                side = side.FlipSide();
            }
        }

        public void HandleCollision()
        {
            collision.ResolveOverlap(mario, side);

            if (side is TopSideCollision)
            {
                enemy.CanDealDamage = false;
                enemy.IsHit();
            }
            else
            {
                if (mario.IsBig() && enemy.CanDealDamage == true)
                {
                    mario.Damage();
                }
                else if (enemy.CanDealDamage == true)
                {
                    mario.Die();
                }
            }
        }
    }
}
