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
        }
    }
}
