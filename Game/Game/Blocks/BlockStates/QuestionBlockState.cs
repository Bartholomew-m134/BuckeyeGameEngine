using Game.Blocks;
using Game.Interfaces;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks.BlockStates
{
    public class QuestionBlockState : IBlockState
    {
        private IBlock block;

        public QuestionBlockState(IBlock block)
        {
            this.block = block;
            block.Sprite = TileSpriteFactory.CreateQuestionBlockSprite();
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
            block.State = new UsedBlockState(block);
        }
    }
}
