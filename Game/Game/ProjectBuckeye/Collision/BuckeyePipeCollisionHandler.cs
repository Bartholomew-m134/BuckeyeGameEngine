using Game.GameStates;
using Game.Utilities;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using Game.SoundEffects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Pipes;
using Game.Interfaces;
using Game.ProjectBuckeye.PlayerClasses;
using Game.Collisions;
using Game.ProjectBuckeye.PlayerClasses.BuckeyePlayerStates;

namespace Game.ProjectBuckeye.Collision
{
    public class BuckeyePipeCollisionHandler
    {
        private IBuckeyePlayer player;
        private IPipe pipe;
        private ICollisionSide side;

        private IGameState gameState;
        private CollisionData collision;

        public BuckeyePipeCollisionHandler(CollisionData collision, IGameState gameState)
        {
            this.collision = collision;
            this.gameState = gameState;

            side = collision.CollisionSide;
            if (collision.GameObjectA is IBuckeyePlayer)
            {
                player = (IBuckeyePlayer)collision.GameObjectA;
                pipe = (IPipe)collision.GameObjectB;
            }
            else
            {
                player = (IBuckeyePlayer)collision.GameObjectB;
                pipe = (IPipe)collision.GameObjectA;
                side = side.FlipSide();
            }
        }

        public void HandleCollision()
        {
            if (!player.IsDead)
            {
                collision.ResolveOverlap(player, side);
                Vector2 warpPipeCoordinateOffsetLeft = new Vector2(CollisionHandlerConstants.WARPPIPECOORDINATEOFFSETLEFT, 0);
                Vector2 warpPipeCoordinateOffsetRight = new Vector2(CollisionHandlerConstants.WARPPIPECOORDINATEOFFSETRIGHT, 0);
                warpPipeCoordinateOffsetLeft += pipe.VectorCoordinates;
                warpPipeCoordinateOffsetRight += pipe.VectorCoordinates;

                if (side is TopSideCollision && player.IsPressingDown() && pipe.IsWarpPipe && !(pipe is SidePipe) && ((warpPipeCoordinateOffsetLeft.X < player.VectorCoordinates.X) && (player.VectorCoordinates.X < warpPipeCoordinateOffsetRight.X)))
                {
                    SoundEffectManager.ShrinkingOrPipeEffect();
                    
                    gameState.PipeTransition(pipe);
                        
                    player.Physics.ResetX();
                }
                else if ((side is LeftSideCollision || side is RightSideCollision) && pipe.IsWarpPipe && (pipe is SidePipe))
                {
                    SoundEffectManager.ShrinkingOrPipeEffect();

                    gameState.PipeTransition(pipe);
                    player.Physics.ResetX();
                }
                else if (side is TopSideCollision)
                {
                    if (!(player.State is BuckeyeLeftIdleState || player.State is BuckeyeRightIdleState))
                        player.Physics.ResetY();
                    if (player.IsJumping())
                        player.State.ToIdle();
                }
                else
                    player.Physics.ResetX();
                }
            }
        }
}