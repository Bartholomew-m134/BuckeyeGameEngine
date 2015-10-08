using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Blocks;

namespace Game.Collisions.BlockCollisionHandling
{
    class MarioQuestionBlockCollisionHandler
    {
        private MarioInstance collidingMario;
        public IBlock collidingBlock;
        public ICollisionSide collisionSide;

        public MarioQuestionBlockCollisionHandler(CollisionData collision)
        {
            if (collision.gameObjectA is IMario)
            {
                collidingMario = (MarioInstance)collision.gameObjectA;
                collidingBlock = (IBlock)collision.gameObjectB;
            }
            else
            {
                collidingMario = (MarioInstance)collision.gameObjectB;
                collidingBlock = (IBlock)collision.gameObjectA;
            }
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
            // stop mario from passing through block
        }
        private void HandleBottomSide()
        {
            collidingBlock.GetUsed();
            // stop mario from going through block
        }
        private void HandleRightSide()
        {
            // stop mario from passing through block
        }
        private void HandleLeftSide()
        {
            // stop mario from passing through block
        }
    }
}
