using Game.Blocks;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States.BlockStates
{
    public class SolidBlockState : IBlockState
    {
        private Block block;

        public SolidBlockState(Block block)
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
