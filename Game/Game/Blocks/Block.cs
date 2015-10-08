using Game.States.BlockStates;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.Blocks
{
    public class Block : IBlock
    {
        public IBlockState blockState;
        public ISprite sprite;
        private Game1 game;
        private int blockType;
        private Vector2 location;

        public Block(int blockType, Game1 game)
        {
            this.game = game;
            this.blockType = blockType;

            switch (blockType)
            {
                case 1:
                    blockState = new BrickBlockState(this);
                    break;
                case 2:
                    blockState = new HiddenBlockState(this);
                    break;
                case 3:
                    blockState = new QuestionBlockState(this);
                    break;
            }
        }

        public void Update()
        {
            blockState.Update();
        }

        public void Draw()
        {
            switch (blockType)
            {
                case 1:
                    sprite.Draw(game.spriteBatch, new Microsoft.Xna.Framework.Vector2(400, 200));
                    break;
                case 2:
                    sprite.Draw(game.spriteBatch, new Microsoft.Xna.Framework.Vector2(200, 200));
                    break;
                case 3:
                    sprite.Draw(game.spriteBatch, new Microsoft.Xna.Framework.Vector2(300, 200));
                    break;
            }
           
        }

        public void Disappear()
        {
            blockState.Disappear();
        }

        public void GetUsed()
        {
            blockState.GetUsed();
        }

        Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        ISprite GetSprite
        {
            get { return sprite; }
        }
    }
}
