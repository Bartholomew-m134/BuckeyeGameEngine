using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Pipes;
using Game.Interfaces;
using Game.Mario.MarioStates;
using Game.GameStates;
using Game.Utilities;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using Game.SoundEffects;

namespace Game.Collisions.PipeCollisionHandling
{
    public class MarioPipeCollisionHandler
    {
        private IMario mario;
        private IPipe pipe;
        private ICollisionSide side;

        private IGameState gameState;
        private CollisionData collision;

        public MarioPipeCollisionHandler(CollisionData collision, IGameState gameState)
        {
            this.collision = collision;
            this.gameState = gameState;

            side = collision.CollisionSide;
            if (collision.GameObjectA is IMario)
            {
                mario = (IMario)collision.GameObjectA;
                pipe = (IPipe)collision.GameObjectB;
            }
            else
            {
                mario = (IMario)collision.GameObjectB;
                pipe = (IPipe)collision.GameObjectA;
                side = side.FlipSide();
            }
        }

        public void HandleCollision()
        {
            ScoreManager.stompStreak = ScoreManagerConstants.RESETTOZERO;
            if (!(mario.MarioState is DeadMarioState))
            {
                collision.ResolveOverlap(mario, side);
                Vector2 warpPipeCoordinateOffsetLeft = new Vector2(CollisionHandlerConstants.WARPPIPECOORDINATEOFFSETLEFT, 0);
                Vector2 warpPipeCoordinateOffsetRight = new Vector2(CollisionHandlerConstants.WARPPIPECOORDINATEOFFSETRIGHT, 0);
                warpPipeCoordinateOffsetLeft += pipe.VectorCoordinates;
                warpPipeCoordinateOffsetRight += pipe.VectorCoordinates;

                if (side is TopSideCollision && mario.IsPressingDown() && pipe.IsWarpPipe && !(pipe is BottomSidePipe) && ((warpPipeCoordinateOffsetLeft.X < mario.VectorCoordinates.X) && (mario.VectorCoordinates.X < warpPipeCoordinateOffsetRight.X)))
                {
                    SoundEffectManager.ShrinkingOrPipeEffect();
                    
                    gameState.PipeTransition(pipe.WarpVectorCoordinates);
                    mario.Physics.ResetX();
                    

                }
                else if ((side is LeftSideCollision || side is RightSideCollision) && pipe.IsWarpPipe && (pipe is BottomSidePipe))
                {
                    SoundEffectManager.ShrinkingOrPipeEffect();

                    gameState.PipeTransition(pipe.WarpVectorCoordinates);
                    mario.Physics.ResetX();


                }
                else if (side is TopSideCollision)
                {
                    mario.Physics.ResetY();
                    if (mario.IsJumping())
                        mario.MarioState.ToIdle();
                }
                else
                    mario.Physics.ResetX();

            }
        }
    }
}
