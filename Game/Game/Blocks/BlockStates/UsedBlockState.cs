using Game.Blocks;
using Game.Interfaces;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks.BlockStates
{
    public class UsedBlockState : IBlockState
    {
        private IBlock block;

        public UsedBlockState(IBlock block)
        {
            this.block = block;
            block.GetSetSprite = TileSpriteFactory.CreateUsedBlockSprite();
        }

        public void Update()
        {
            block.GetSetSprite.Update();
        }

        public void Disappear()
        {

        }

        public void GetUsed()
        {

        }
    }
}
