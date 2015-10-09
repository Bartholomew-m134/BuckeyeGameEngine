using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Collisions
{
    public class BottomSideCollision : ICollisionSide
    {
        public BottomSideCollision()
        {

        }

        public ICollisionSide FlipSide()
        {
            return new TopSideCollision();
        }
    }
}
