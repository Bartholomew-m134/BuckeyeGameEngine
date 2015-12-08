using Game.Blocks;
using Game.Collisions;
using Game.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectMarioBrickBreaker.Collision
{
    public class PaddleBlockCollisionHandler
    {
        private IPaddle paddle;
        private ICollisionSide collisionSide;
        private CollisionData collision;

        public PaddleBlockCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            collisionSide = (ICollisionSide)collision.CollisionSide;
            if (collision.GameObjectA is IPaddle)
            {
                paddle = (IPaddle)collision.GameObjectA;
            }
            else
            {
                paddle = (IPaddle)collision.GameObjectB;
                collisionSide = collisionSide.FlipSide();
            }
        }

        public void HandleCollision()
        {
            collision.ResolveOverlap(paddle, collisionSide);
            paddle.Physics.Velocity = Vector2.Zero;
        }
    }
}
