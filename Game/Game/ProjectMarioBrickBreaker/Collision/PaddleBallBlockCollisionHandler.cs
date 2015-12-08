using Game.Blocks;
using Game.Blocks.BlockStates;
using Game.Collisions;
using Game.GameStates;
using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectMarioBrickBreaker.Collision
{
    public class PaddleBallBlockCollisionHandler
    {

        private IPaddleBall collidingBall;
        private IBlock collidingBlock;
        private ICollisionSide collisionSide;
        private CollisionData collision;
        private IGameState brickBreakerGameState;

        public PaddleBallBlockCollisionHandler(CollisionData collision, IGameState gameState)
        {
            this.collision = collision;
            brickBreakerGameState = gameState;
            collisionSide = (ICollisionSide)collision.CollisionSide;
            if (collision.GameObjectA is IPaddleBall)
            {
                collidingBall = (IPaddleBall)collision.GameObjectA;
                collidingBlock = (IBlock)collision.GameObjectB;
            }
            else
            {
                collidingBall = (IPaddleBall)collision.GameObjectB;
                collidingBlock = (IBlock)collision.GameObjectA;
                collisionSide = collisionSide.FlipSide();
            }
        }

        public void HandleCollision()
        {
            HandleScore();

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
            if (collidingBlock.State is BrickBlockState)
            {
                
                if (!collidingBall.IsSuperPaddleBall())
                {
                    collision.ResolveOverlap(collidingBall, collisionSide);
                    collidingBall.Physics.Velocity = new Vector2(collidingBall.Physics.Velocity.X, -collidingBall.Physics.Velocity.Y);
                }
                collidingBlock.Disappear();
                ((MarioBrickBreakerGameState)brickBreakerGameState).BrickBlockCount--;
            }
            else if (!(collidingBlock.State is BrickDebrisState))
            {
                collision.ResolveOverlap(collidingBall, collisionSide);
                collidingBall.Physics.Velocity = new Vector2(collidingBall.Physics.Velocity.X, -collidingBall.Physics.Velocity.Y);
            }
            
        }
        private void HandleBottomSide()
        {
            HandleTopSide();
        }
        private void HandleRightSide()
        {
            if (collidingBlock.State is BrickBlockState)
            {
                
                if (!collidingBall.IsSuperPaddleBall())
                {
                    collision.ResolveOverlap(collidingBall, collisionSide);
                    collidingBall.Physics.Velocity = new Vector2(-collidingBall.Physics.Velocity.X, collidingBall.Physics.Velocity.Y);
                }
                collidingBlock.Disappear();
                ((MarioBrickBreakerGameState)brickBreakerGameState).BrickBlockCount--;
            }
            else if (!(collidingBlock.State is BrickDebrisState))
            {
                collision.ResolveOverlap(collidingBall, collisionSide);
                collidingBall.Physics.Velocity = new Vector2(-collidingBall.Physics.Velocity.X, collidingBall.Physics.Velocity.Y);
            }
            
        }
        private void HandleLeftSide()
        {
            HandleRightSide();
        }

        private void HandleScore()
        {
            
            if (collidingBlock.State is BrickBlockState)
            {
                ScoreManager.IncreaseScore(ScoreManagerConstants.FIFTYPOINTS);
                ScoreManager.location = collidingBlock.VectorCoordinates;
            }
        }
    }
}
