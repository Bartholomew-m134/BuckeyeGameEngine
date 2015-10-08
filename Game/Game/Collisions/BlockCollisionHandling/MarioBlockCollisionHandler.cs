using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Blocks;
using Game.States.BlockStates;

namespace Game.Collisions.BlockCollisionHandling
{
    class MarioBlockCollisionHandler
    {
        private MarioInstance collidingMario;
        public Block collidingBlock;
        public ICollisionSide collisionSide;

        public MarioBlockCollisionHandler(CollisionData collision)
        {
            if (collision.gameObjectA is IMario)
            {
                collidingMario = (MarioInstance)collision.gameObjectA;
                collidingBlock = (Block)collision.gameObjectB;
            }
            else
            {
                collidingMario = (MarioInstance)collision.gameObjectB;
                collidingBlock = (Block)collision.gameObjectA;
            }
            collisionSide = (ICollisionSide)collision.collisionSide;
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
            if (!(collidingBlock.blockState is HiddenBlockState)){
                // do not let mario pass through
            }

        }
        private void HandleBottomSide()
        {
            if (collidingBlock.blockState is HiddenBlockState){
                collidingBlock.GetUsed();
                // do not let mario pass through
            }
            else if (collidingBlock.blockState is BrickBlockState && collidingMario.IsBig()){
                collidingBlock.Disappear();
            }
            else if (collidingBlock.blockState is QuestionBlockState){
                collidingBlock.GetUsed();
                // do not let mario pass through
            }
            else
            {
                // do not let mario pass through
            }
        }
        private void HandleRightSide()
        {
            if (!(collidingBlock.blockState is HiddenBlockState))
            {
                // do not let mario pass through
            }
        }
        private void HandleLeftSide()
        {
            if (!(collidingBlock.blockState is HiddenBlockState))
            {
                // do not let mario pass through
            }
        }
    }
}
