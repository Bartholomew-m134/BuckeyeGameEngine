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
            

            collision.ResolveOverlap(mario, side);
            if (side is TopSideCollision)
            {
                mario.Physics.ResetY();
                if (mario.IsJumping())
                    mario.MarioState.ToIdle();
            }
            else
                mario.Physics.ResetX();

            if (side is LeftSideCollision)
                Console.WriteLine("Left");
            else if (side is BottomSideCollision)
                Console.WriteLine("Bottom");

            

        }
    }
}
