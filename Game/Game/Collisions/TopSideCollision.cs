﻿using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Collisions
{
    public class TopSideCollision : ICollisionSide
    {
        public TopSideCollision()
        {

        }

        public ICollisionSide FlipSide()
        {
            return new BottomSideCollision();
        }
    }
}
