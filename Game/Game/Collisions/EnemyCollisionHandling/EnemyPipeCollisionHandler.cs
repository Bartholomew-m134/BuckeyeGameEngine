using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;

namespace Game.Collisions.EnemyCollisionHandling
{
    public class EnemyPipeCollisionHandler
    {
        private IEnemy enemy;
        IPipe pipe;
        private ICollisionSide side;
        private CollisionData collision;

        public EnemyPipeCollisionHandler(CollisionData collision)
        {
            this.collision = collision;

            side = collision.CollisionSide;
            if (collision.GameObjectA is IEnemy)
            {
                enemy = (IEnemy)collision.GameObjectA;
                pipe = (IPipe)collision.GameObjectB;
            }
            else
            {
                enemy = (IEnemy)collision.GameObjectB;
                pipe = (IPipe)collision.GameObjectA;
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
