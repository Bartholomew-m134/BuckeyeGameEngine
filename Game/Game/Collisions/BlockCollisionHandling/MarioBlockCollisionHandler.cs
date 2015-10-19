using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Blocks;
using Game.Blocks.BlockStates;
using System.Diagnostics;
using Game.Interfaces;

namespace Game.Collisions.BlockCollisionHandling
{
    public class MarioBlockCollisionHandler
    {

        private IMario collidingMario;
        private Block collidingBlock;
        private ICollisionSide collisionSide;
        private CollisionData collision;

        public MarioBlockCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            collisionSide = (ICollisionSide)collision.collisionSide;
            if (collision.gameObjectA is IMario)
            {
                collidingMario = (IMario)collision.gameObjectA;
                collidingBlock = (Block)collision.gameObjectB;
            }
            else
            {
                collidingMario = (IMario)collision.gameObjectB;
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
            if (!(collidingBlock.State is HiddenBlockState)){
                collision.ResolveOverlap(collidingMario, collisionSide);
            }

        }
        private void HandleBottomSide()
        {
            if (collidingBlock.State is HiddenBlockState){
                collidingBlock.GetUsed();
                collision.ResolveOverlap(collidingMario, collisionSide);
            }
            else if (collidingBlock.State is BrickBlockState && collidingMario.IsBig())
            {
                collidingBlock.Disappear();
            }
            else if (collidingBlock.State is QuestionBlockState)
            {
                collidingBlock.GetUsed();
                collision.ResolveOverlap(collidingMario, collisionSide);
            } 
            else {
                collision.ResolveOverlap(collidingMario, collisionSide);
            }
        }
        private void HandleRightSide()
        {
            if (!(collidingBlock.State is HiddenBlockState))
            {
                collision.ResolveOverlap(collidingMario, collisionSide);
            }

        }
        private void HandleLeftSide()
        {
            if (!(collidingBlock.State is HiddenBlockState))
            {
                collision.ResolveOverlap(collidingMario, collisionSide);
            }
        }
    }
}
