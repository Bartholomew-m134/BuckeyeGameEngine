using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Collisions;
using Game.Blocks.BlockStates;
using Game.Blocks;
using Game.ProjectBuckeye.PlayerClasses.BuckeyePlayerStates;

namespace Game.ProjectBuckeye.Collision
{
    public class BuckeyeTileCollisionHandler
    {
        private IBuckeyePlayer player;
        private ICollisionSide collisionSide;
        private CollisionData collision;

        public BuckeyeTileCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            collisionSide = (ICollisionSide)collision.CollisionSide;
            if (collision.GameObjectA is IBuckeyePlayer)
            {
                player = (IBuckeyePlayer)collision.GameObjectA;
            }
            else
            {
                player = (IBuckeyePlayer)collision.GameObjectB;
                collisionSide = collisionSide.FlipSide();
            }
        }

        public void HandleCollision()
        {
            ResetYPhysicsIfNotIdle();
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
            player.Physics.ResetPhysics();
        }
        private void HandleLeftSide()
        {
            collision.ResolveOverlap(player, collisionSide);
            player.Physics.ResetPhysics();
        }

        private void ResetYPhysicsIfNotIdle()
        {
            if (!(player.State is BuckeyeRightIdleState || player.State is BuckeyeLeftIdleState || player.State is BuckeyeLeftDownState || player.State is BuckeyeRightDownState))
                player.Physics.ResetY();
        }
    }
}
