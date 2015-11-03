using Game.Blocks.BlockStates;
using Game.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities;
using Game.SoundEffects;

namespace Game.Blocks
{
    public class Block : IBlock
    {
        public enum Type {NullBlock, BrickBlock, HiddenBlock, QuestionBlock, SolidBlock, BreakingBlock};
        
        private IBlockState blockState;
        private ISprite sprite;
        private Game1 game;
        private Vector2 location;
        private bool isBumped;
        private ObjectPhysics physics;

        public Block(Type blockType, Game1 game)
        {
            isBumped = false;
            this.game = game;
            SetInitialState(blockType);
            physics = new ObjectPhysics();
            physics.Acceleration = Vector2.Zero;
        }

        public void Update()
        {
            blockState.Update();

            if (isBumped && physics.Velocity.Y == 2)
            {
                isBumped = false;
                physics.ResetPhysics();
                physics.Acceleration = Vector2.Zero;
            }

            if (isBumped)
                location = physics.Update(location);
        }

        public void Draw(ICamera camera)
        {    
            sprite.Draw(game.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public void Bump()
        {
            if (!isBumped)
            {
                isBumped = true;
                SoundEffectManager.BlockBumpedEffect();
                physics.ResetPhysics();
                physics.Velocity = new Vector2(0,-2);
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

        public ISprite Sprite
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

        public ObjectPhysics Physics
        {
            get { return null; }
        }

        public bool IsBumped
        {
            get { return isBumped; }

        }
    }
}
