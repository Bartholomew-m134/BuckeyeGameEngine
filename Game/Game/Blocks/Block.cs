﻿using Game.Blocks.BlockStates;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks
{
    public class Block : IBlock
    {
        public enum Type {NullBlock, BrickBlock, HiddenBlock, QuestionBlock, SolidBlock, BreakingBlock};
        
        private IBlockState blockState;
        private ISprite sprite;
        private Game1 game;
        private Vector2 location;

        public Block(Type blockType, Game1 game)
        {
            this.game = game;
            SetInitialState(blockType);           
        }

        public void Update()
        {
            blockState.Update();
        }

        public void Draw()
        {
            sprite.Draw(game.spriteBatch, location);
        }

        public void Disappear()
        {
            blockState.Disappear();
            location = new Vector2(-1000,-1000);
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

        public ISprite GetSetSprite
        {
            get { return sprite; }
            set { sprite = value; }
        }

        public IBlockState State
        {
            get { return blockState; }
            set { blockState = value; }
        }

        private void SetInitialState(Type blockType)
        {
            switch (blockType)
            {
                case Type.BrickBlock:
                    blockState = new BrickBlockState(this);
                    break;
                case Type.HiddenBlock:
                    blockState = new HiddenBlockState(this);
                    break;
                case Type.QuestionBlock:
                    blockState = new QuestionBlockState(this);
                    break;
                case Type.SolidBlock:
                    blockState = new SolidBlockState(this);
                    break;
                case Type.BreakingBlock:
                    blockState = new BreakingBlockState(this);
                    break;
                case Type.NullBlock:
                    blockState = new NullBlockState(this);
                    break;
            }
        }
    }
}
