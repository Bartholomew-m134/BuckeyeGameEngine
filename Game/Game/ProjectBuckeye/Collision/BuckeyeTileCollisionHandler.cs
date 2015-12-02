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
    public class BuckeyeTileCollisionHandler
    {
        private IBuckeyePlayer player;
        private IBuckeyeTile block;
        private ICollisionSide collisionSide;
        private CollisionData collision;

        public BuckeyeTileCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            collisionSide = (ICollisionSide)collision.CollisionSide;
            if (collision.GameObjectA is IBuckeyePlayer)
            {
                player = (IBuckeyePlayer)collision.GameObjectA;
                block = (IBuckeyeTile)collision.GameObjectB;
            }
            else
            {
                player = (IBuckeyePlayer)collision.GameObjectB;
                block = (IBuckeyeTile)collision.GameObjectA;
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
            collision.ResolveOverlap(player, collisionSide);
            if (player.IsJumping())
                player.ToIdle();
        }
        private void HandleBottomSide()
        {
            collision.ResolveOverlap(player, collisionSide);
            player.Physics.ResetY();
        }
        private void HandleRightSide()
        {
            collision.ResolveOverlap(player, collisionSide);
        }
        private void HandleLeftSide()
        {
            collision.ResolveOverlap(player, collisionSide);
        }
    }
}
