using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;

namespace Game.Collisions.EnemyCollisionHandling
{
    class EnemyEnemyCollisionHandler
    {
        private CollisionData collision;

        public EnemyEnemyCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
        }

        public void HandleCollision()
        {
            collision.ResolveOverlap(collision.GameObjectA, collision.CollisionSide);
            if (collision.CollisionSide is LeftSideCollision || collision.CollisionSide is RightSideCollision)
            {
                ((IEnemy)collision.GameObjectA).ShiftDirection();
                ((IEnemy)collision.GameObjectB).ShiftDirection();
            }
        }
    }
}
