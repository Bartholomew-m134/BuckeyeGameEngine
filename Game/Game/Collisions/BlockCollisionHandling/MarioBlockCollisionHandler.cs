using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Blocks;
using Game.States.BlockStates;
using System.Diagnostics;

namespace Game.Collisions.BlockCollisionHandling
{
    class MarioBlockCollisionHandler
    {

        private MarioInstance collidingMario;
        public Block collidingBlock;
        public ICollisionSide collisionSide;
        private CollisionData collision;

        public MarioBlockCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            collisionSide = (ICollisionSide)collision.collisionSide;
            if (collision.gameObjectA is IMario)
            {
                collidingMario = (MarioInstance)collision.gameObjectA;
                collidingBlock = (Block)collision.gameObjectB;
            }
            else
            {
                collidingMario = (MarioInstance)collision.gameObjectB;
                collidingBlock = (Block)collision.gameObjectA;
                collisionSide = collisionSide.FlipSide();
            }
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
                collision.ResolveOverlap(collidingMario, collisionSide);
            }

        }
        private void HandleBottomSide()
        {
            if (collidingBlock.blockState is HiddenBlockState){
                collidingBlock.GetUsed();
                collision.ResolveOverlap(collidingMario, collisionSide);
            }
            else if (collidingBlock.blockState is BrickBlockState && collidingMario.IsBig()){
                collidingBlock.Disappear();
            }
            else if (collidingBlock.blockState is QuestionBlockState){
                collidingBlock.GetUsed();
                collision.ResolveOverlap(collidingMario, collisionSide);
            }
            else if(collidingBlock.blockState is BreakingBlockState){
                collidingBlock.Disappear();
            }
            else {
                collision.ResolveOverlap(collidingMario, collisionSide);
            }
        }
        private void HandleRightSide()
        {
            if (!(collidingBlock.blockState is HiddenBlockState))
            {
                collision.ResolveOverlap(collidingMario, collisionSide);
            }

        }
        private void HandleLeftSide()
        {
            if (!(collidingBlock.blockState is HiddenBlockState))
            {
                collision.ResolveOverlap(collidingMario, collisionSide);
            }
        }
    }
}
