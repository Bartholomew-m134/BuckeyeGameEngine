using Game.Interfaces;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks.BlockStates
{
    public class VerticalBlockWallState : IBlockState
    {
        private IBlock block;

        public VerticalBlockWallState(IBlock block)
        {
            this.block = block;
            block.Sprite = TileSpriteFactory.CreateVerticalBlockWallSprite();
        }

        public void Update()
        {
            block.Sprite.Update();
        }

        public void Disappear()
        {

        }

        public void GetUsed()
        {

        }
    }
}
