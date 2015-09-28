﻿using Game.Blocks;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States.BlockStates
{
    public class NullBlockState : IBlockState
    {

        public NullBlockState(Block block)
        {        
            block.sprite = TileSpriteFactory.CreateHiddenBlockSprite();
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
