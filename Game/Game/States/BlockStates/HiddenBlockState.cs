using Game.Blocks;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States.BlockStates
{
    public class HiddenBlockState : IBlockState
    {
        private Block block;

        public HiddenBlockState(Block block)
        {
            this.block = block;
            block.sprite = TileSpriteFactory.CreateHiddenBlockSprite();
        }

        public void Update()
        {
            block.sprite.Update();
        }
        public void Disappear()
        {
        }

        public void GetUsed()
        {
            block.blockState = new UsedBlockState(block);
        }
    }
}
