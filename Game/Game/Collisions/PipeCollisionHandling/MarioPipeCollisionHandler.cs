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
                if (side is TopSideCollision && mario.IsPressingDown() && pipe.IsWarpPipe)
                {
                    gameState.PipeTransition(pipe.WarpVectorCoordinates);

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
