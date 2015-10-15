using Game.Blocks;
using Game.Interfaces;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks.BlockStates
{
    public class NullBlockState : IBlockState
    {

        public NullBlockState(IBlock block)
        {
            block.GetSetSprite = TileSpriteFactory.CreateHiddenBlockSprite();
        }

        public void Update()
        {
            
        }


        public void Disappear()
        {

        }

        public void GetUsed()
        {

        }
    }
}
