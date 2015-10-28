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
            Rectangle previousHitBoxB;
            Rectangle hitBoxB;
            Rectangle collisionRectangle;

            Vector2 objectAOldCoordinates;
            Vector2 objectBOldCoordinates;

            if (objectA.Physics != null)
            {
                objectAOldCoordinates = objectA.Physics.OldCoordinates;

                if (objectA.Physics.Velocity.Y > 0)
                {
                    objectAOldCoordinates.Y--;
                }
            }
            else
                objectAOldCoordinates = objectA.VectorCoordinates;

            if (objectB.Physics != null)
            {
                objectBOldCoordinates = objectB.Physics.OldCoordinates;

                if (objectB.Physics.Velocity.Y > 0)
                {
                    objectBOldCoordinates.Y--;
                }
            }
            else
                objectBOldCoordinates = objectB.VectorCoordinates;

            previousHitBoxA = new Rectangle((int)objectAOldCoordinates.X, (int)objectAOldCoordinates.Y, (int)objectA.Sprite.SpriteDimensions.X, (int)objectA.Sprite.SpriteDimensions.Y);
            previousHitBoxB = new Rectangle((int)objectBOldCoordinates.X, (int)objectBOldCoordinates.Y, (int)objectB.Sprite.SpriteDimensions.X, (int)objectB.Sprite.SpriteDimensions.Y);

            hitBoxA = new Rectangle((int)objectA.VectorCoordinates.X, (int)objectA.VectorCoordinates.Y, (int)objectA.Sprite.SpriteDimensions.X, (int)objectA.Sprite.SpriteDimensions.Y);
            hitBoxB = new Rectangle((int)objectB.VectorCoordinates.X, (int)objectB.VectorCoordinates.Y, (int)objectB.Sprite.SpriteDimensions.X, (int)objectB.Sprite.SpriteDimensions.Y);

            collisionRectangle = Rectangle.Intersect(hitBoxA, hitBoxB);
            

            if (collisionRectangle.IsEmpty || objectA is IScenery || objectB is IScenery)
            {
                collisionSide = null;
            }       
            else if (isTopLeftCorner(hitBoxA, hitBoxB))
            {
                if ((previousHitBoxA.Right <= previousHitBoxB.Left) && (previousHitBoxA.Bottom > previousHitBoxB.Top))
                {
                   
                    collisionSide = new LeftSideCollision();
                }
                else
                    collisionSide = new TopSideCollision();
            }
            else if (isTopRightCorner(hitBoxA, hitBoxB))
            {
                if ((previousHitBoxA.Left >= previousHitBoxB.Right) && (previousHitBoxA.Bottom > previousHitBoxB.Top))
                {
                    
                    collisionSide = new RightSideCollision();
                    
                }
                else
                    collisionSide = new TopSideCollision();
            }
            else if (isBottomLeftCorner(hitBoxA, hitBoxB))
            {
                if ((previousHitBoxA.Right <= previousHitBoxB.Left) && (previousHitBoxA.Top < previousHitBoxB.Bottom))
                    collisionSide = new LeftSideCollision();
                else             
                    collisionSide = new BottomSideCollision();
            }
            else if (isBottomRightCorner(hitBoxA, hitBoxB))
            {
                if ((previousHitBoxA.Left >= previousHitBoxB.Right) && (previousHitBoxA.Top < previousHitBoxB.Bottom))
                {
                    collisionSide = new RightSideCollision();
                }
                else
                    collisionSide = new BottomSideCollision();
            }
            else
            {
                collisionSide = new TopSideCollision();
            }

            return collisionSide;
        }

        private static bool isTopLeftCorner(Rectangle hitBoxA, Rectangle hitBoxB)
        {
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
