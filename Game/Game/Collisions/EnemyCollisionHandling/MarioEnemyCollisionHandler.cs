using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Enemies;
using Game.Enemies.GoombaClasses;
using Game.Enemies.KoopaClasses;
using Game.Interfaces;
using Microsoft.Xna.Framework;

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
            if (!mario.IsStar() && side is TopSideCollision)
            {
                collision.ResolveOverlap(mario, side);
                enemy.CanDealDamage = false;
                enemy.Hit();

                mario.Physics.Velocity = new Vector2(mario.Physics.Velocity.X, -5);
                mario.Physics.Acceleration = new Vector2(mario.Physics.Acceleration.X, 1);
            }
            else if(!mario.IsStar() && enemy.CanDealDamage)
            {
                collision.ResolveOverlap(mario, side);
                mario.Damage();
            }
            else if (mario.IsStar())
            {
                enemy.CanDealDamage = false;
                enemy.Flipped();
            }
        }
    }
}
