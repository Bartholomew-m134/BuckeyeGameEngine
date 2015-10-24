using Game.Blocks;
using Game.Interfaces;
using Game.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Collisions.ItemCollisionHandling
{
    public class ItemBlockCollisionHandler
    {
        private Block collidingBlock;
        private IItem collidingItem;
        private ICollisionSide side;
        private CollisionData collision;

        public ItemBlockCollisionHandler(CollisionData collision) {
            this.collision = collision;
            side = collision.CollisionSide;
            if (collision.GameObjectA is IBlock)
            {
                collidingBlock = (Block)collision.GameObjectA;
                collidingItem = (IItem)collision.GameObjectB;
            }
            else
            {
                collidingBlock = (Block)collision.GameObjectB;
                collidingItem = (IItem)collision.GameObjectA;
                side = side.FlipSide();
            }

        }
        public void HandleCollision()
        {
            if (collidingBlock.isBumped && side is BottomSideCollision)
            {
                collidingItem.IsInsideBlock = false;
            }
            else if (!collidingItem.IsInsideBlock)
            {
                collision.ResolveOverlap(collidingItem, collision.CollisionSide);

            }

        }
    }
}
