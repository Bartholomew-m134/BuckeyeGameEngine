using Game.Blocks;
using Game.Blocks.BlockStates;
using Game.Interfaces;
using Game.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Collisions.ItemCollisionHandling
{
    public class ItemPipeCollisionHandler
    {
        private IPipe collidingPipe;
        private IItem collidingItem;
        private ICollisionSide side;
        private CollisionData collision;

        public ItemPipeCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            side = collision.CollisionSide;
            if (collision.GameObjectA is IItem)
            {
                collidingItem = (IItem)collision.GameObjectA;
                collidingPipe = (IPipe)collision.GameObjectB;
            }
            else
            {
                collidingPipe = (IPipe)collision.GameObjectA;
                collidingItem = (IItem)collision.GameObjectB;
                side = side.FlipSide();
            }

        }
        public void HandleCollision()
        {
            if (!collidingItem.IsInsideBlock && (side is LeftSideCollision || side is RightSideCollision))
            {
                Console.WriteLine("Left");
                collision.ResolveOverlap(collidingItem, side);
                collidingItem.ReverseDirection();
            }
            else if (!collidingItem.IsInsideBlock)
            {
                Console.WriteLine("Other");
                collision.ResolveOverlap(collidingItem, side);
                collidingItem.Physics.ResetPhysics();
            }
        }
    }
}
