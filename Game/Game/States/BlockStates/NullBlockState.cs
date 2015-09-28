using Game.Blocks;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States.BlockStates
{
    public class NullBlockState : IBlockState
    {
        private Game1 game;
        private Block block;

        public NullBlockState(Block block, Game1 game)
        {
            this.game = game;
            this.block = block;
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
