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
    class WolverinePipeCollisionHandler
    {
        private IWolverine enemy;
        private IPipe pipe;
        private ICollisionSide collisionSide;
        private CollisionData collision;

        public WolverinePipeCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            collisionSide = (ICollisionSide)collision.CollisionSide;
            if (collision.GameObjectA is IWolverine)
            {
                enemy = (IWolverine)collision.GameObjectA;
                pipe = (IPipe)collision.GameObjectB;
            }
            else
            {
                enemy = (IWolverine)collision.GameObjectB;
                pipe = (IPipe)collision.GameObjectA;
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
