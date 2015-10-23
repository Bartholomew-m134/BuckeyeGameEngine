using Game.Blocks;
using Game.Interfaces;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks.BlockStates
{
    public class BrickBlockState : IBlockState
    {
        private IBlock block;

        public BrickBlockState(IBlock block)
        {
            this.block = block;
            block.Sprite = TileSpriteFactory.CreateBrickBlockSprite();
        }

        public void Update()
        {
            block.Sprite.Update();
        }

        public void Disappear()
        {
            block.State = new BrickDebrisState(block);
        }

        public void GetUsed()
        {
            
        }
    }
}
