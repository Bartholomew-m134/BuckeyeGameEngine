using Game.Interfaces;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks.BlockStates
{
    public class HorizontalBlockWallState : IBlockState
    {
        private IBlock block;

        public HorizontalBlockWallState(IBlock block)
        {
            this.block = block;
            block.Sprite = TileSpriteFactory.CreateHorizontalBlockWallSprite();
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
