using Game.States.BlockStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks
{
    public class Block : IBlock
    {
        public IBlockState blockState;
        public ISprite sprite; 
        private Game1 game;

        public Block(int block, Game1 game)
        {
            this.game = game;

            switch (block){
                case 1:
                    blockState = new BrickBlockState(this, game);
                    break;
                case 2:
                    blockState = new HiddenBlockState(this, game);
                    break;
                case 3:
                    blockState = new QuestionBlockState(this, game);
                    break;
            }
        }

        public void Update()
        {
            blockState.Update();
        }

        public void Draw()
        {
            sprite.Draw(game.spriteBatch, new Microsoft.Xna.Framework.Vector2(10, 10));
        }


    }
}
