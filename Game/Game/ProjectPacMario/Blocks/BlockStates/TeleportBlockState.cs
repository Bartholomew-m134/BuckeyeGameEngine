using Game.Blocks;
using Game.Interfaces;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectPacMario.Blocks.BlockStates
{
    public class TeleportBlockState : IBlockState
    {
        private IBlock block;

        public TeleportBlockState(IBlock block)
        {
            
            this.block = block;
            block.Sprite = TileSpriteFactory.CreateHiddenBlockSprite();
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

        }
    }
}
