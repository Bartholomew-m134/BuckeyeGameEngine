using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Blocks;
using Game.Mario;

namespace Game.Collisions.BlockCollisionHandling
{
    class MarioBrickBlockCollisionHandler
    {
        private MarioInstance collidingMario;
        public IBlock collidingBlock;
        public ICollisionSide collisionSide;

        public MarioBrickBlockCollisionHandler(CollisionData collision) 
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
            // stop mario from passing through the block
        }
        private void HandleBottomSide()
        {
            if (collidingMario.IsBig())
            {
                collidingBlock.Disappear();
                // initiate block breaking animation
                // stop mario from passing through the block
            }
            else
            {
                // stop mario from passing through the block
            }
        }
        private void HandleRightSide()
        {
            // stop mario from passing through the block
        }
        private void HandleLeftSide()
        {
            // stop mario from passing through the block
        }
    }
}
