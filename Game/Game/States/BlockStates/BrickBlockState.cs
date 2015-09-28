using Game.Blocks;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States.BlockStates
{
    public class BrickBlockState : IBlockState
    {
        private Block block;

        public BrickBlockState(Block block)
        {
            this.block = block;
            block.sprite = TileSpriteFactory.CreateBrickBlockSprite();
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
