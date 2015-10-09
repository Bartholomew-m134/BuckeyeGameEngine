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
        private Collision collision;

        public MarioBlockCollisionHandler(Collision collision)
        {
            this.collision = collision;
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
                collision.ResolveOverlap(collidingMario);
            }

        }
        private void HandleBottomSide()
        {
            if (collidingBlock.blockState is HiddenBlockState){
                collidingBlock.GetUsed();
                collision.ResolveOverlap(collidingMario);
            }
            else if (collidingBlock.blockState is BrickBlockState && collidingMario.IsBig()){
                collidingBlock.Disappear();
            }
            else if (collidingBlock.blockState is QuestionBlockState){
                collidingBlock.GetUsed();
                collision.ResolveOverlap(collidingMario);
            }
            else if(collidingBlock.blockState is BreakingBlockState){
                collidingBlock.Disappear();
            }
            else
            {
                collision.ResolveOverlap(collidingMario);
            }
        }
        private void HandleRightSide()
        {
            if (!(collidingBlock.blockState is HiddenBlockState))
            {
                collision.ResolveOverlap(collidingMario);
            }
        }
        private void HandleLeftSide()
        {
            if (!(collidingBlock.blockState is HiddenBlockState))
            {
                collision.ResolveOverlap(collidingMario);
            }
        }
    }
}
