﻿using Game.Blocks;
using Game.Interfaces;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks.BlockStates
{
    public class BreakingBlockState : IBlockState
    {
        private IBlock block;

        public BreakingBlockState(IBlock block, bool isUnderground)
        {
            this.block = block;
            if (isUnderground)
                block.Sprite = TileSpriteFactory.CreateUndergroundBreakingBlockSprite();
            else
                block.Sprite = TileSpriteFactory.CreateBreakingBlockSprite();
        }

        public void Update()
        {
            block.Sprite.Update();
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
