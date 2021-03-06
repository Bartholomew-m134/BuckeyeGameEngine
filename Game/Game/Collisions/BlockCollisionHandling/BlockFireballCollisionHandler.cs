﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Projectiles;
using Game.Interfaces;
using Game.Blocks.BlockStates;
using Microsoft.Xna.Framework;

namespace Game.Collisions.BlockCollisionHandling
{
    public class BlockFireballCollisionHandler
    {
        private CollisionData collision;
        private IProjectile fireball;
        private IBlock block;
        private ICollisionSide side;

        public BlockFireballCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            this.side = collision.CollisionSide;

            if (collision.GameObjectA is IProjectile)
            {
                fireball = (IProjectile)collision.GameObjectA;
                block = (IBlock)collision.GameObjectB;
                
            }
            else
            {
                fireball = (IProjectile)collision.GameObjectB;
                block = (IBlock)collision.GameObjectA;
                this.side.FlipSide();
            }
        }

        public void HandleCollision()
        {
            collision.ResolveOverlap(fireball, side);

            if (side is TopSideCollision && !(block.State is HiddenBlockState))
                fireball.Bounce();
            else if(!(block.State is HiddenBlockState))
                fireball.Explode();
            
        }
    }
}
