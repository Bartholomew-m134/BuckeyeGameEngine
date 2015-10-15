﻿using Game.Blocks;
using Game.Interfaces;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks.BlockStates
{
    public class HiddenBlockState : IBlockState
    {
        private IBlock block;

        public HiddenBlockState(IBlock block)
        {
            this.block = block;
            block.GetSetSprite = TileSpriteFactory.CreateHiddenBlockSprite();
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
            block.State = new UsedBlockState(block);
        }
    }
}
