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
        private Rectangle hitBoxA;
        private Rectangle hitBoxB;
        private Rectangle collisionRectangle;

        private ICollisionSide collisionSide;

        public CollisionDetector(Rectangle hitBox1, Rectangle hitBox2)
        {
            hitBoxA = hitBox1;
            hitBoxB = hitBox2;
        }
    }
}
