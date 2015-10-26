using Game.FlagPoles;
using Game.Interfaces;
using Game.Mario;
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
            if(collidingFlagPole is InvisibleFlagPoleBarrier && collision.CollisionSide is LeftSideCollision){
                collidingMario.PoleSlide();
                collision.ResolveOverlap(collidingMario, collision.CollisionSide);;
            }
            collidingFlagPole.IsActive = true;
            if(collision.CollisionSide is BottomSideCollision){
               
            }
            
        }
    }
}
