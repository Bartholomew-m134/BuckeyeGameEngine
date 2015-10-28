﻿using Game.Blocks;
using Game.Blocks.BlockStates;
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
            if (collision.GameObjectA is IItem)
            {             
                collidingItem = (IItem)collision.GameObjectA;
                collidingBlock = (Block)collision.GameObjectB;        
            }
            else
            {
                collidingBlock = (Block)collision.GameObjectA;
                collidingItem = (IItem)collision.GameObjectB;
                side = side.FlipSide();
            }

        }
        public void HandleCollision()
        {

            if (collidingBlock.isBumped && side is TopSideCollision && collidingItem.VectorCoordinates.X == collidingBlock.VectorCoordinates.X)           
                collidingItem.Release();
            
            if (!collidingItem.IsInsideBlock && (side is TopSideCollision || side is BottomSideCollision) &&  !(collidingBlock.State is HiddenBlockState))
            {
                if (!(collidingItem is Star))
                {
                    collision.ResolveOverlap(collidingItem, side);
                    collidingItem.Physics.ResetY();
                }
                else 
                {
                    if (side is TopSideCollision)
                        collidingItem.Physics.Velocity = new Microsoft.Xna.Framework.Vector2(collidingItem.Physics.Velocity.X, -8);
                    
                }
            }
            else if (!collidingItem.IsInsideBlock &&  !(collidingBlock.State is HiddenBlockState))
            {
                collision.ResolveOverlap(collidingItem, side);
                collidingItem.ReverseDirection();
            }
        }
    }
}
