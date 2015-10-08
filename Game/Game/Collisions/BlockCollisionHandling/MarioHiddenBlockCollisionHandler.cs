using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Blocks;
using Game.Mario;

namespace Game.Collisions.BlockCollisionHandling
{
    class MarioHiddenBlockCollisionHandler
    {
        private MarioInstance collidingMario;
        public IBlock collidingBlock;
        public ICollisionSide collisionSide;

        public MarioHiddenBlockCollisionHandler(CollisionData collision)
        {
            collidingMario = (MarioInstance)collision.gameObjectA;
            collidingBlock = (IBlock)collision.gameObjectB;
            collisionSide = collision.collisionSide;
        }

        public void HandleCollision()
        {
            if (collisionSide is RightSideCollision){
                HandleRightSide();
            }
            else if(collisionSide is LeftSideCollision){
                HandleLeftSide();
            }
            else if (collisionSide is TopSideCollision){
                HandleTopSide();
            }
            else{
                HandleBottomSide();
            }
            
        }
        private void HandleTopSide()
        {
            // mario will pass through the block
        }
        private void HandleBottomSide()
        {
            collidingBlock.GetUsed();
            // stop mario from going through block
        }
        private void HandleRightSide()
        {
            // mario will pass through the block
        }
        private void HandleLeftSide()
        {
            // mario will pass through the block
        }
    }
}
