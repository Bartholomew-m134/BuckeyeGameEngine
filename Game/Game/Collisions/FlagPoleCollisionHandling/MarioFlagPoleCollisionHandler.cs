using Game.FlagPoles;
using Game.Interfaces;
using Game.Mario;
using Game.Mario.MarioStates;
using Game.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Collisions.FlagPoleCollisionHandling
{
    public class MarioFlagPoleCollisionHandler
    {
        private IFlagPole collidingFlagPole;
        private IMario collidingMario;
        private CollisionData collision;

        public MarioFlagPoleCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            if (collision.GameObjectA is IFlagPole)
            {
                collidingFlagPole = (IFlagPole)collision.GameObjectA;
                collidingMario = (IMario)collision.GameObjectB;
            }
            else
            {
                collidingFlagPole = (IFlagPole)collision.GameObjectB;
                collidingMario = (IMario)collision.GameObjectA;
            }

        }
        public void HandleCollision()
        {
            if (!(collidingMario.MarioState is DeadMarioState))
            {
                if (collidingFlagPole is InvisibleFlagPoleBarrier && collision.CollisionSide is RightSideCollision)
                {
                    collidingMario.PoleSlide();
                }
                else if (collidingFlagPole is FlagPole)
                {
                    collidingFlagPole.IsActive = true;
                }
            }
            HandleScore();
        }

        public void HandleScore()
        {
            if (collidingFlagPole is TopOfPole && ScoreManager.flagTopBeenHit == false)
            {
                ScoreManager.IncreaseScore(3000);
                ScoreManager.location = WorldManager.camera.GetAdjustedPosition(collidingFlagPole.VectorCoordinates);
                ScoreManager.flagTopBeenHit = true;
            }
        }
    }
}
