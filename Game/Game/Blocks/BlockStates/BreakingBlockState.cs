using Game.Blocks;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks.BlockStates
{
    public class BreakingBlockState : IBlockState
    {
        private IBlock block;

        public BreakingBlockState(IBlock block)
        {
            this.block = block;
            block.GetSetSprite = TileSpriteFactory.CreateBreakingBlockSprite();
        }

        public void Update()
        {
            block.GetSetSprite.Update();
        }

        public void Disappear()
        {
            block.State = new NullBlockState(block);
        }

        public void GetUsed()
        {
            
        }
    }
}
