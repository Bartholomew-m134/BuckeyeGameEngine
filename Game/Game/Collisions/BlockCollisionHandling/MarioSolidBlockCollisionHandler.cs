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
        private MarioInstance collidingMario;
        public IBlock collidingBlock;
        public ICollisionSide collisionSide;

        public MarioSolidBlockCollisionHandler(CollisionData collision) {
            collidingMario = (MarioInstance)collision.gameObjectA;
            collidingBlock = (IBlock)collision.gameObjectB;
            collisionSide = collision.collisionSide;
        }

        public void HandleCollision()
        {
            if (collisionSide is RightSideCollision)
            {
                HandleRightSide();
            }
            else if (collisionSide is LeftSideCollision)
            {
                HandleLeftSide();
            }
            else if (collisionSide is TopSideCollision)
            {
                HandleTopSide();
            }
            else
            {
                HandleBottomSide();
            }

        }
        private void HandleTopSide()
        {
            // stop mario from going through block
        }
        private void HandleBottomSide()
        {
            // stop mario from going through block
        }
        private void HandleRightSide()
        {
            // stop mario from going through block
        }
        private void HandleLeftSide()
        {
            // stop mario from going through block
        }
    }
}
