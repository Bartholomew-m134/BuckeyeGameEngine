using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Mario;
using Game.Enemies;

namespace Game.Collisions
{
    public static class CollisionDetector
    {
        public ICollisionSide DetectCollision(IGameObject objectA, IGameObject objectB)
        {
            ICollisionSide collisionSide;
            Rectangle hitBoxA;
            Rectangle hitBoxB;

            Rectangle hitBoxA = new Rectangle((int)objectA.VectorCoordinates.X, (int)objectA.VectorCoordinates.Y, width, height);

            Rectangle collisionRectangle = Rectangle.Intersect(hitBoxA, hitBoxB);

            if (collisionRectangle.IsEmpty)
            {
                collisionSide = null;
            }
            else if (collisionRectangle.Width > collisionRectangle.Height)
            {
                if (hitBoxA.Bottom < hitBoxB.Top)
                {
                    collisionSide = new TopSideCollision();
                }
                else
                {
                    collisionSide = new BottomSideCollision();
                }
            }
            else
            {
                if (hitBoxA.Right > hitBoxB.Left)
                {
                    collisionSide = new LeftSideCollision();
                }
                else
                {
                    collisionSide = new RightSideCollision();
                }
            }

            return collisionSide;
        }

    }
}
