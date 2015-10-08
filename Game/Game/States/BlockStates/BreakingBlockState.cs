using Game.Blocks;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States.BlockStates
{
    public class BreakingBlockState : IBlockState
    {
        private Block block;

        public BreakingBlockState(Block block)
        {
            this.block = block;
            block.sprite = TileSpriteFactory.CreateBreakingBlockSprite();
        }

        public void Update()
        {
            block.sprite.Update();
        }

        public void Disappear()
        {
            block.blockState = new NullBlockState(block);
        }

        public void GetUsed()
        {
            
        }
    }
}
