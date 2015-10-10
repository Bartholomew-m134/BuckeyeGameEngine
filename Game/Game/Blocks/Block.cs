using Game.States.BlockStates;
using Microsoft.Xna.Framework;
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
        public int blockType;
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
                case 4:
                    blockState = new SolidBlockState(this);
                    break;
                case 5:
                    blockState = new BreakingBlockState(this);
                    break;
                case 6:
                    blockState = new NullBlockState(this);
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
                    sprite.Draw(game.spriteBatch, location);
                    
                    break;
                case 2:
                    sprite.Draw(game.spriteBatch, location);
                
                    break;
                case 3:
                    sprite.Draw(game.spriteBatch, location);

                    break;
                case 4:
                    sprite.Draw(game.spriteBatch, location);
                    break;
                case 5:
                    sprite.Draw(game.spriteBatch, location);
                    break;
                case 6:
                    blockState = new NullBlockState(this);
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

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite GetSprite
        {
            get { return sprite; }
            set { sprite = value; }
        }
    }
}
