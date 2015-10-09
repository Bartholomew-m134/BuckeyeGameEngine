using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Pipes;

namespace Game.Collisions.PipeCollisionHandling
{
    public class MarioPipeCollisionHandler
    {
        private MarioInstance mario;
        private IPipe pipe;
        private ICollisionSide side;
        private CollisionData collision;

        public MarioPipeCollisionHandler(CollisionData collision)
        {
            this.collision = collision;

            side = collision.collisionSide;
            if (collision.gameObjectA is IMario)
            {
                mario = (MarioInstance)collision.gameObjectA;
                pipe = (IPipe)collision.gameObjectB;
            }
            else
            {
                mario = (MarioInstance)collision.gameObjectB;
                pipe = (IPipe)collision.gameObjectA;
                side = side.FlipSide();
            }
        }

        public void HandleCollision()
        {
            collision.ResolveOverlap(mario, side);
        }
    }
}
