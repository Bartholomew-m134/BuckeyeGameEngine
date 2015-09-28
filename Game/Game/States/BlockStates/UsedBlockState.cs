using Game.Blocks;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States.BlockStates
{
    public class UsedBlockState : IBlockState
    {
        private Block block;

        public UsedBlockState(Block block)
        {
            this.block = block;
            block.sprite = TileSpriteFactory.CreateUsedBlockSprite();
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

        }
    }
}
