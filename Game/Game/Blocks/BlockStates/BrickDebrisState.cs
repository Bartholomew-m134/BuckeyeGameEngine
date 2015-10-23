using Game.Blocks;
using Game.Interfaces;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks.BlockStates
{
    class BrickDebrisState : IBlockState
    {

        private IBlock block;

        public BrickDebrisState(IBlock block)
        {
            this.block = block;
            block.GetSetSprite = TileSpriteFactory.CreateBrickDebrisSprite();
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
