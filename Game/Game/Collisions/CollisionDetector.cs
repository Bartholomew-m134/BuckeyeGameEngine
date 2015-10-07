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
        public ICollisionSide DetectCollision(Rectangle hitBoxA, Rectangle hitBoxB)
        {
            ICollisionSide collisionSide;

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
