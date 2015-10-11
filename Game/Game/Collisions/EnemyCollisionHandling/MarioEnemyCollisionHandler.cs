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
        private IMario mario;
        private IEnemy enemy;
        private ICollisionSide side;
        private CollisionData collision;
        public MarioEnemyCollisionHandler(CollisionData collision)
        {
            this.collision = collision;

            side = collision.collisionSide;
            if (collision.gameObjectA is IMario)
            {
                mario = (IMario)collision.gameObjectA;
                enemy = (IEnemy)collision.gameObjectB;
            }
            else
            {
                mario = (IMario)collision.gameObjectB;
                enemy = (IEnemy)collision.gameObjectA;
                side = side.FlipSide();
            }
        }

        public void HandleCollision()
        {
            collision.ResolveOverlap(mario, side);

            if (side is TopSideCollision && !mario.IsStar())
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
