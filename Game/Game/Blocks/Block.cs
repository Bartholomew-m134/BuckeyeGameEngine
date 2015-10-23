using Game.Blocks.BlockStates;
using Game.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities;

namespace Game.Blocks
{
    public class Block : IBlock
    {
        public enum Type {NullBlock, BrickBlock, HiddenBlock, QuestionBlock, SolidBlock, BreakingBlock};
        
        private IBlockState blockState;
        private IBlockSprite sprite;
        private Game1 game;
        private Vector2 location;
        public bool isBumped;
        private int bumpTimer;

        public Block(Type blockType, Game1 game)
        {
            isBumped = false;
            bumpTimer = 20;
            this.game = game;
            SetInitialState(blockType);           
        }

        public void Update()
        {
            blockState.Update();
        }

        public void Draw(ICamera camera)
        {
            if (isBumped && (bumpTimer >0))
            {
                BumpDraw(camera);
                bumpTimer--;
            }
            else
            {
                sprite.Draw(game.spriteBatch, camera.GetAdjustedPosition(location));
                bumpTimer = 20;
                isBumped = false;
            }
        }

        public void BumpDraw(ICamera camera)
        {
            sprite.BumpDraw(game.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public void Disappear()
        {
            blockState.Disappear();
            //WorldManager.FreeObject(this);
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

        public ISprite Sprite
        {
            get { return (ISprite)sprite; }
            set { sprite = (IBlockSprite)value; }
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

        public ObjectPhysics Physics
        {
            get { return null; }
        }
    }
}
