using Game.Blocks;
using Game.Interfaces;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks.BlockStates
{
    public class SolidBlockState : IBlockState
    {
        private IBlock block;

        public SolidBlockState(IBlock block)
        {
            this.block = block;
            block.GetSetSprite = TileSpriteFactory.CreateSolidBlockSprite();
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
