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
        private Game1 game;
        private Block block;

        public BrickBlockState(Block block, Game1 game)
        {
            this.game = game;
            this.block = block;
            block.sprite = TileSpriteFactory.CreateBrickBlockSprite(game);
        }

        public void Update()
        {
            block.sprite.Update();
        }

        public void Disappear()
        {
            block.blockState = new NullBlockState(block, game);
        }

        public void GetUsed()
        {
            
        }
    }
}
