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
        private IBlock block;

        public QuestionBlockState(IBlock block)
        {
            this.block = block;
            block.GetSetSprite = TileSpriteFactory.CreateQuestionBlockSprite();
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
