using Game.States.BlockStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Game.Blocks
{
    public class BrickBlock : IBlock
    {
        public IBlockState blockState;
        public ISprite sprite;
        private Game1 game;

        public BrickBlock(Game1 game)
        {
            this.game = game;
            blockState = new BrickBlockState(this, game);
        }

        public void Update()
        {
            blockState.Update();
        }

        public void Draw()
        {
            sprite.Draw(game.spriteBatch, new Microsoft.Xna.Framework.Vector2(10, 10));
        }

        public void Disappear()
        {
            blockState = new HiddenBlockState(game);
        }
    }
}
