using Game.Collisions;
using Game.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectMarioBrickBreaker.Collision
{
    public class PaddlePaddleBallCollisionHandler
    {
        private IPaddle paddle;
        private IPaddleBall collidingBall;
        private ICollisionSide collisionSide;
        private CollisionData collision;

        public PaddlePaddleBallCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            collisionSide = (ICollisionSide)collision.CollisionSide;
            if (collision.GameObjectA is IPaddle)
            {
                paddle = (IPaddle)collision.GameObjectA;
                collidingBall = (IPaddleBall)collision.GameObjectB;

                collisionSide = collisionSide.FlipSide();
            }
            else
            {
                paddle = (IPaddle)collision.GameObjectB;
                collidingBall = (IPaddleBall)collision.GameObjectA;
                
            }
        }

        public void HandleCollision() 
        {
            if (collisionSide is TopSideCollision)
                HandleTopSide();
            else if (collisionSide is BottomSideCollision)
                HandleBottomSide();
            else if (collisionSide is RightSideCollision)
                HandleRightSide();
            else
                HandleLeftSide();
        }

        private void HandleTopSide()
        {
            collision.ResolveOverlap(collidingBall, collisionSide);
            if(paddle.Physics.Velocity.X > 0)
              collidingBall.Physics.Velocity = new Vector2(collidingBall.Physics.VelocityMaximum.X, -collidingBall.Physics.Velocity.Y);
            else if(paddle.Physics.Velocity.X < 0)
              collidingBall.Physics.Velocity = new Vector2(collidingBall.Physics.VelocityMinimum.X, -collidingBall.Physics.Velocity.Y);
            else
              collidingBall.Physics.Velocity = new Vector2(collidingBall.Physics.Velocity.X, -collidingBall.Physics.Velocity.Y);

        }

        private void HandleBottomSide()
        {
            collision.ResolveOverlap(paddle, collisionSide);
            if (paddle.Physics.Velocity.X > 0)
                collidingBall.Physics.Velocity = new Vector2(collidingBall.Physics.VelocityMaximum.X, -collidingBall.Physics.Velocity.Y);
            else if (paddle.Physics.Velocity.X < 0)
                collidingBall.Physics.Velocity = new Vector2(collidingBall.Physics.VelocityMinimum.X, -collidingBall.Physics.Velocity.Y);
            else
                collidingBall.Physics.Velocity = new Vector2(collidingBall.Physics.Velocity.X, -collidingBall.Physics.Velocity.Y);

        }

        private void HandleLeftSide()
        {
            collision.ResolveOverlap(collidingBall, collisionSide);
            collidingBall.Physics.Velocity = new Vector2(-collidingBall.Physics.Velocity.X, collidingBall.Physics.Velocity.Y);

        }

        private void HandleRightSide() {
            HandleLeftSide();
        }
    }
}
