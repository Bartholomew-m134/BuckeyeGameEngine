﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Collisions
{
    public static class CollisionDetector
    {
        public ICollisionSide DetectCollision(IGameObject objectA, IGameObject objectB)
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
            else if (collisionRectangle.Width > collisionRectangle.Height && hitBoxA.Bottom < hitBoxB.Top)
            {
                collisionSide = new TopSideCollision();
            }
            else if (collisionRectangle.Width > collisionRectangle.Height)
            {
                collisionSide = new BottomSideCollision();
            }
            else if (collisionRectangle.Height >= collisionRectangle.Width && hitBoxA.Right > hitBoxB.Left)
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
