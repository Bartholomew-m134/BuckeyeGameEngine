using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;

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
            collision.ResolveOverlap(enemy, side);
            if (side is LeftSideCollision || side is RightSideCollision)
            {
                enemy.ShiftDirection();
            }
        }
    }
}
