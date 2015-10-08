using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Diagnostics;

namespace Game.Collisions
{
    public static class CollisionDetector
    {
        public static ICollisionSide DetectCollision(IGameObject objectA, IGameObject objectB)
        {
            ICollisionSide collisionSide;
            Rectangle hitBoxA;
            Rectangle hitBoxB;
            Rectangle collisionRectangle;

            hitBoxA = new Rectangle((int)objectA.VectorCoordinates.X, (int)objectA.VectorCoordinates.Y, (int)objectA.GetSprite.SpriteDimensions.X, (int)objectA.GetSprite.SpriteDimensions.Y);
            hitBoxB = new Rectangle((int)objectB.VectorCoordinates.X, (int)objectB.VectorCoordinates.Y, (int)objectB.GetSprite.SpriteDimensions.X, (int)objectB.GetSprite.SpriteDimensions.Y);

            collisionRectangle = Rectangle.Intersect(hitBoxA, hitBoxB);

            if (collisionRectangle.IsEmpty)
            {
                
                collisionSide = null;
            }
            else if ((collisionRectangle.Width > collisionRectangle.Height) && (hitBoxA.Bottom > hitBoxB.Top))
            {
                Debug.WriteLine("Top\n");
                Debug.WriteLine(objectA.ToString());
                Debug.WriteLine(objectB.ToString());
                collisionSide = new TopSideCollision();
            }
            else if (collisionRectangle.Width > collisionRectangle.Height)
            {
                collisionSide = new BottomSideCollision();
                Debug.WriteLine("Bottom\n");
            }
            else if (collisionRectangle.Height < collisionRectangle.Width && hitBoxA.Right > hitBoxB.Left)
            {
                collisionSide = new LeftSideCollision();
                Debug.WriteLine("Left\n");
            }
            else
            {
                collisionSide = new RightSideCollision();
                Debug.WriteLine("Right\n");
                
                Debug.WriteLine(objectA.ToString());
                Debug.WriteLine(objectB.ToString());
            }

            return collisionSide;
        }

    }
}
