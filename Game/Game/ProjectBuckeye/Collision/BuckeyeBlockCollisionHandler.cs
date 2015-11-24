using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Collisions;
using Game.Blocks.BlockStates;
using Game.Blocks;

namespace Game.ProjectBuckeye.Collision
{
    public class BuckeyeBlockCollisionHandler
    {
        private IBuckeyePlayer player;
        private Block block;
        private ICollisionSide collisionSide;
        private CollisionData collision;

        public BuckeyeBlockCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            collisionSide = (ICollisionSide)collision.CollisionSide;
            if (collision.GameObjectA is IBuckeyePlayer)
            {
                player = (IBuckeyePlayer)collision.GameObjectA;
                block = (Block)collision.GameObjectB;
            }
            else
            {
                player = (IBuckeyePlayer)collision.GameObjectB;
                block = (Block)collision.GameObjectA;
                collisionSide = collisionSide.FlipSide();
            }
        }

        public void HandleCollision()
        {
            if (collisionSide is RightSideCollision)
                HandleRightSide();
            else if (collisionSide is LeftSideCollision)
                HandleLeftSide();
            else if (collisionSide is TopSideCollision)
                HandleTopSide();
            else
                HandleBottomSide();
        }

        private void HandleTopSide()
        {
            if (!(block.State is HiddenBlockState) && !(block.State is BrickDebrisState))
            {
                collision.ResolveOverlap(player, collisionSide);
                if (player.IsJumping())
                {
                    player.ToIdle();
                }
            }
        }
        private void HandleBottomSide()
        {
            if (block.State is HiddenBlockState && player.Physics.Velocity.Y <= 0)
            {
                block.GetUsed();
                block.Bump();
                collision.ResolveOverlap(player, collisionSide);
            }
            else if (block.State is QuestionBlockState)
            {
                block.GetUsed();
                block.Bump();
                collision.ResolveOverlap(player, collisionSide);
            }
            else if (!(block.State is BrickDebrisState) && !(block.State is HiddenBlockState))
            {
                collision.ResolveOverlap(player, collisionSide);
            }

            if (!(block.State is NullBlockState || block.State is BrickDebrisState || block.State is HiddenBlockState))
                player.Physics.ResetY();
        }
        private void HandleRightSide()
        {
            if (!(block.State is HiddenBlockState) && !(block.State is BrickDebrisState))
            {
                collision.ResolveOverlap(player, collisionSide);
            }

        }
        private void HandleLeftSide()
        {
            if (!(block.State is HiddenBlockState) && !(block.State is BrickDebrisState))
            {
                collision.ResolveOverlap(player, collisionSide);
            }
        }
    }
}
