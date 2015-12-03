using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Collisions;

namespace Game.ProjectBuckeye.Collision
{
    public class WolverineTileCollisionHandler
    {
        private IWolverine enemy;
        private IBuckeyeTile block;
        private ICollisionSide collisionSide;
        private CollisionData collision;

        public WolverineTileCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            collisionSide = (ICollisionSide)collision.CollisionSide;
            if (collision.GameObjectA is IWolverine)
            {
                enemy = (IWolverine)collision.GameObjectA;
                block = (IBuckeyeTile)collision.GameObjectB;
            }
            else
            {
                enemy = (IWolverine)collision.GameObjectB;
                block = (IBuckeyeTile)collision.GameObjectA;
                collisionSide = collisionSide.FlipSide();
            }
        }

        public void HandleCollision()
        {
            enemy.Physics.ResetY();
            collision.ResolveOverlap(enemy, collisionSide);
        }
    }
}
