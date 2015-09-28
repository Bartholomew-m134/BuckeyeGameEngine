using Game.Blocks;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States.BlockStates
{
    public class QuestionBlockState : IBlockState
    {
        private Block block;

        public QuestionBlockState(Block block)
        {
            this.block = block;
            block.sprite = TileSpriteFactory.CreateQuestionBlockSprite();
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
            block.blockState = new UsedBlockState(block);
        }
    }
}
