using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Diagnostics;
using Game.Interfaces;

namespace Game.Collisions
{
    public static class CollisionDetector
    {
        public static ICollisionSide DetectCollision(IGameObject objectA, IGameObject objectB)
        {
            ICollisionSide collisionSide;
            Rectangle hitBoxA;
            Rectangle previousHitBoxA;
            Rectangle hitBoxB;
            Rectangle collisionRectangle;
            Vector2 objectAOldCoordinates;

            if (objectA.Physics != null)
                objectAOldCoordinates = objectA.Physics.OldCoordinates;
            else
                objectAOldCoordinates = objectA.VectorCoordinates;

            previousHitBoxA = new Rectangle((int)objectAOldCoordinates.X, (int)objectAOldCoordinates.Y, (int)objectA.Sprite.SpriteDimensions.X, (int)objectA.Sprite.SpriteDimensions.Y);
            hitBoxA = new Rectangle((int)objectA.VectorCoordinates.X, (int)objectA.VectorCoordinates.Y, (int)objectA.Sprite.SpriteDimensions.X, (int)objectA.Sprite.SpriteDimensions.Y);
            hitBoxB = new Rectangle((int)objectB.VectorCoordinates.X, (int)objectB.VectorCoordinates.Y, (int)objectB.Sprite.SpriteDimensions.X, (int)objectB.Sprite.SpriteDimensions.Y);
            
            collisionRectangle = Rectangle.Intersect(hitBoxA, hitBoxB);

            if (collisionRectangle.IsEmpty)
            {
                
                collisionSide = null;
            }
            else if (isTopLeftCorner(hitBoxA, hitBoxB)) {

                if (isTopLeftCorner(previousHitBoxA, hitBoxB) || isTopRightCorner(previousHitBoxA, hitBoxB))
                {
                    collisionSide = new TopSideCollision();
                }else{
                    collisionSide = new LeftSideCollision();
                }
            }
            else if (isTopRightCorner(hitBoxA, hitBoxB))
            {

                if (isTopLeftCorner(previousHitBoxA, hitBoxB) || isTopRightCorner(previousHitBoxA, hitBoxB))
                {
                    collisionSide = new TopSideCollision();
                }
                else
                {
                    collisionSide = new RightSideCollision();
                }
            }
            else if (isBottomLeftCorner(hitBoxA, hitBoxB))
            {

                if (isBottomLeftCorner(previousHitBoxA, hitBoxB) || isBottomRightCorner(previousHitBoxA, hitBoxB))
                {
                    collisionSide = new BottomSideCollision();
                }
                else
                {
                    collisionSide = new LeftSideCollision();
                }
            }
            else if (isBottomRightCorner(hitBoxA, hitBoxB))
            {

                if (isBottomLeftCorner(previousHitBoxA, hitBoxB) || isBottomRightCorner(previousHitBoxA, hitBoxB))
                {
                    collisionSide = new BottomSideCollision();
                }
                else
                {
                    collisionSide = new RightSideCollision();
                }
            }
            else {
                collisionSide = new TopSideCollision();
            }

           
            /*else if ((collisionRectangle.Width >= collisionRectangle.Height) && (previousHitBoxA.Bottom < hitBoxB.Top))
            {
                collisionSide = new TopSideCollision();
            }
            else if ((collisionRectangle.Width >= collisionRectangle.Height) && (previousHitBoxA.Top > hitBoxA.Bottom))
            {
                collisionSide = new BottomSideCollision();
            }
            else if ((collisionRectangle.Height >= collisionRectangle.Width) && (previousHitBoxA.Right < hitBoxB.Left))
            {
                collisionSide = new LeftSideCollision();
            }
            else
            {
                collisionSide = new RightSideCollision();
            }
             */

            return collisionSide;
        }

        private static bool isTopLeftCorner(Rectangle hitBoxA, Rectangle hitBoxB) {

            return ((hitBoxA.X <= hitBoxB.X) && (hitBoxA.Y <= hitBoxB.Y));
        }

        private static bool isTopRightCorner(Rectangle hitBoxA, Rectangle hitBoxB)
        {

            return ((hitBoxA.X > hitBoxB.X) && (hitBoxA.Y <= hitBoxB.Y));
        }

        private static bool isBottomLeftCorner(Rectangle hitBoxA, Rectangle hitBoxB)
        {

            return ((hitBoxA.X <= hitBoxB.X) && (hitBoxA.Y > hitBoxB.Y));
        }

        private static bool isBottomRightCorner(Rectangle hitBoxA, Rectangle hitBoxB)
        {

            return ((hitBoxA.X > hitBoxB.X) && (hitBoxA.Y > hitBoxB.Y));
        }
    }
}
