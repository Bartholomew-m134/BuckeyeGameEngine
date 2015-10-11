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

            hitBoxA = new Rectangle((int)objectA.VectorCoordinates.X, (int)objectA.VectorCoordinates.Y, (int)objectA.GetSetSprite.SpriteDimensions.X, (int)objectA.GetSetSprite.SpriteDimensions.Y);
            hitBoxB = new Rectangle((int)objectB.VectorCoordinates.X, (int)objectB.VectorCoordinates.Y, (int)objectB.GetSetSprite.SpriteDimensions.X, (int)objectB.GetSetSprite.SpriteDimensions.Y);
            
            collisionRectangle = Rectangle.Intersect(hitBoxA, hitBoxB);

            if (collisionRectangle.IsEmpty)
            {
                
                collisionSide = null;
            }
            else if ((collisionRectangle.Width > collisionRectangle.Height) && (hitBoxA.Bottom < hitBoxB.Bottom))
            {
                collisionSide = new TopSideCollision();
            }
            else if (collisionRectangle.Width > collisionRectangle.Height)
            {
                collisionSide = new BottomSideCollision();
            }
            else if (collisionRectangle.Height > collisionRectangle.Width && hitBoxA.Right < hitBoxB.Right)
            {
                collisionSide = new LeftSideCollision();
            }
            else
            {
                collisionSide = new RightSideCollision();
            }

            return collisionSide;
        }

    }
}
