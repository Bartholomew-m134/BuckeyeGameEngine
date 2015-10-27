using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Enemies.KoopaClasses;
using Microsoft.Xna.Framework;
using Game.Blocks;

namespace Game.Collisions.EnemyCollisionHandling
{
    public class EnemyBlockCollisionHandler
    {
        private IEnemy enemy;
        IBlock block;
        private ICollisionSide side;
        private CollisionData collision;

        public EnemyBlockCollisionHandler(CollisionData collision)
        {
            this.collision = collision;

            side = collision.CollisionSide;
            if (collision.GameObjectA is IEnemy)
            {
                enemy = (IEnemy)collision.GameObjectA;
                block = (IBlock)collision.GameObjectB;
            }
            else
            {
                enemy = (IEnemy)collision.GameObjectB;
                block = (IBlock)collision.GameObjectA;
                side = side.FlipSide();
            }
        }

        public void HandleCollision()
        {
            if(!enemy.IsFlipped)
                collision.ResolveOverlap(enemy, side);
            if (side is LeftSideCollision)
            {
                enemy.ShiftDirection();
                if (enemy is GreenKoopa && ((GreenKoopa)enemy).IsWeaponized)
                {
                    enemy.Physics.Velocity = new Vector2(-12, enemy.Physics.Velocity.Y);
                }
            }
            else if (side is RightSideCollision)
            {
                enemy.ShiftDirection();
                if (enemy is GreenKoopa && ((GreenKoopa)enemy).IsWeaponized)
                {
                    enemy.Physics.Velocity = new Vector2(12, enemy.Physics.Velocity.Y);
                }
            }
            else if (side is TopSideCollision && ((Block)block).isBumped)
            {
                enemy.CanDealDamage = false;
                enemy.Flipped();
            }
        }
    }
}
