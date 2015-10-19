using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Collisions
{
    public class LeftSideCollision : ICollisionSide
    {
        public LeftSideCollision()
        {

        }

        public ICollisionSide FlipSide()
        {
            return new RightSideCollision();
        }
    }
}
