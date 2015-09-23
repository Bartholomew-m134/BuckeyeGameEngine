﻿using Game.Blocks;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States.BlockStates
{
    public class UsedBlockState : IBlockState
    {
        private Game1 game;
        private Block block;

        public UsedBlockState(Block block, Game1 game)
        {
            this.game = game;
            this.block = block;
            block.sprite = 
     
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
