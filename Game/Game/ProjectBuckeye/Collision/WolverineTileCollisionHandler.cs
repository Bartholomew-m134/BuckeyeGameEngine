using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Collisions;
using Game.ProjectBuckeye.EnemyClasses.WolverineChuckStates;
using Game.ProjectBuckeye.EnemyClasses.WolverineStates;

namespace Game.ProjectBuckeye.Collision
{
    public class WolverineTileCollisionHandler
    {
        private IWolverine enemy;
        private ICollisionSide collisionSide;
        private CollisionData collision;

        public WolverineTileCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            collisionSide = (ICollisionSide)collision.CollisionSide;
            if (collision.GameObjectA is IWolverine)
            {
                enemy = (IWolverine)collision.GameObjectA;
            }
            else
            {
                enemy = (IWolverine)collision.GameObjectB;
                collisionSide = collisionSide.FlipSide();
            }
        }

        public void HandleCollision()
        {
            if(!(enemy.State is WolverineChuckIdleLeftState || enemy.State is WolverineChuckIdleRightState || enemy.State is WolverineLeftIdleState))
                enemy.Physics.ResetY();
            if (collisionSide is TopSideCollision)
                enemy.IsGrounded = true;
            collision.ResolveOverlap(enemy, collisionSide);
        }
    }
}
