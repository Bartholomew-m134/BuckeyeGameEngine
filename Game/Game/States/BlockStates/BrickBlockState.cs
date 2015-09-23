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
        private ISprite sprite;

        public BrickBlockState(Game1 game)
        {
            this.game = game;
            sprite = BlockSpriteFactory.CreateBrickBlockSprite(game);
        }


        public void Draw()
        {
            
        }

        public void Update()
        {
            
        }

        public IBlockState Disappear()
        {
            return new HiddenBlockState(game);
        }
    }
}
