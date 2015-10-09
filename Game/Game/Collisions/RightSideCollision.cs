using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Collisions
{
    public class RightSideCollision : ICollisionSide
    {
        public RightSideCollision()
        {

        }

        public ICollisionSide FlipSide()
        {
            return new LeftSideCollision();
        }
    }
}
