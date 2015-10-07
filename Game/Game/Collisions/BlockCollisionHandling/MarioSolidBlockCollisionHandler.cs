using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Blocks;
using Game.Mario;
using Game.Collisions;

namespace Game.Collisions.BlockCollisionHandling
{
    class MarioSolidBlockCollisionHandler
    {
        public MarioInstance collidingMario;
        public Block collidingBlock;
        public ICollisionSide collidingSide;

    }
}
