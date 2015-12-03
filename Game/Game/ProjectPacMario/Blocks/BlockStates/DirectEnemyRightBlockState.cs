using Game.Blocks.BlockStates;
using Game.Interfaces;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectPacMario.Blocks.BlockStates
{
    public class DirectEnemyRightBlockState : IBlockState
    {
        private IBlock block;

        public DirectEnemyRightBlockState(IBlock block)
        {
            this.block = block;
            block.Sprite = TileSpriteFactory.CreateUndergroundBreakingBlockSprite();
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
