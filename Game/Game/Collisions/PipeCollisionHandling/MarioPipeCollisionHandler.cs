using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Pipes;
using Game.Interfaces;

namespace Game.Collisions.PipeCollisionHandling
{
    public class MarioPipeCollisionHandler
    {
        private IMario mario;
        private IPipe pipe;
        private ICollisionSide side;
        private CollisionData collision;

        public MarioPipeCollisionHandler(CollisionData collision)
        {
            this.collision = collision;

            side = collision.collisionSide;
            if (collision.gameObjectA is IMario)
            {
                mario = (IMario)collision.gameObjectA;
                pipe = (IPipe)collision.gameObjectB;
            }
            else
            {
                mario = (IMario)collision.gameObjectB;
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
