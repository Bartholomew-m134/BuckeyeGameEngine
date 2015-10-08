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

        public MarioEnemyCollisionHandler(CollisionData collision)
        {
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
                if (side is TopSideCollision)
                {
                    side = new BottomSideCollision();
                }
                else if (side is BottomSideCollision)
                {
                    side = new TopSideCollision();
                }
                else if (side is RightSideCollision)
                {
                    side = new LeftSideCollision();
                }
                else
                {
                    side = new RightSideCollision();
                }
            }
        }

        public void HandleCollision()
        {
            if (side is TopSideCollision)
            {
                enemy.IsHit();
            }
            else if (side is BottomSideCollision)
            {
                if (mario.IsBig())
                {
                    mario.Damage();
                }
                else
                {
                    mario.Die();
                }
            }
            else if (side is LeftSideCollision)
            {
                if (mario.IsBig())
                {
                    mario.Damage();
                }
                else
                {
                    mario.Die();
                }
            }
            else
            {
                if (mario.IsBig())
                {
                    mario.Damage();
                }
                else
                {
                    mario.Die();
                }
            }
        }
    }
}
