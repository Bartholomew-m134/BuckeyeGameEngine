using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Enemies;
using Game.Enemies.GoombaClasses;
using Game.Enemies.KoopaClasses;

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
                if (enemy.CanDealDamage)
                {
                    mario.Damage();
                }
            }
        }
    }
}
