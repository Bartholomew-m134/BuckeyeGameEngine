using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Collisions
{
    public class CollisionDetector
    {
        private ICollisionSide collisionSide;

        public CollisionDetector(Rectangle hitBoxA, Rectangle hitBoxB)
        {
            Rectangle collisionRectangle = Rectangle.Intersect(hitBoxA, hitBoxB);

            if (collisionRectangle.IsEmpty)
            {
                collisionSide = null;
            }
            else if (collisionRectangle.Width > collisionRectangle.Height)
            {
                if (hitBoxA.Bottom > collisionRectangle.Top)
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
                if (hitBoxA.Right < collisionRectangle.Left)
                {
                    collisionSide = new LeftSideCollision();
                }
                else
                {
                    collisionSide = new RightSideCollision();
                }
            }
        }

        public ICollisionSide CollisionSide
        {
            get { return collisionSide; }
        }

    }
}
