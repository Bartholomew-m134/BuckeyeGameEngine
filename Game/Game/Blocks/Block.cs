using Game.Blocks.BlockStates;
using Game.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities;
using Game.SoundEffects;
using Game.Utilities.Constants;
using Game.ProjectPacMario.Blocks.BlockStates;

namespace Game.Blocks
{
    public class Block : IBlock
    {
        public enum Type {NullBlock, BrickBlock, HiddenBlock, QuestionBlock, SolidBlock, BreakingBlock, 
            EnemyDownBlock, EnemyUpBlock, EnemyLeftBlock, EnemyRightBlock,TeleportBlock, VerticalBlockWall, HorizontalBlockWall};
        
        private IBlockState blockState;
        private ISprite sprite;
        private Game1 game;
        private ISpawner spawner;
        private Vector2 location;
        private bool isBumped;
        private IPhysics physics;

        public Block(Type blockType, bool isUnderground, Game1 game)
        {
            isBumped = false;
            this.game = game;
            SetInitialState(blockType, isUnderground);
            physics = new MarioGamePhysics();
            physics.Acceleration = Vector2.Zero;
        }

        public Block(Type blockType, ISpawner spawner, bool isUnderground, Game1 game)
        {
            isBumped = false;
            this.game = game;
            this.spawner = spawner;
            SetInitialState(blockType, isUnderground);
            physics = new MarioGamePhysics();
            physics.Acceleration = Vector2.Zero;           
        }

        public void Update()
        {
            blockState.Update();

            if (isBumped && physics.Velocity.Y == IBlockConstants.YVELOCITYCAP)
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
                physics.Velocity = new Vector2(0,IBlockConstants.BUMPEDBLOCKVELOCITY);

                if(spawner != null)
                    spawner.Release();
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

        private void SetInitialState(Type blockType, bool isUnderground)
        {
            switch (blockType)
            {
                case Type.BrickBlock:
                    blockState = new BrickBlockState(this, isUnderground);
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
                    blockState = new BreakingBlockState(this, isUnderground);
                    break;
                case Type.NullBlock:
                    blockState = new NullBlockState(this);
                    break;
                case Type.EnemyUpBlock:
                    blockState = new DirectEnemyUpBlockState(this);
                    break;
                case Type.EnemyDownBlock:
                    blockState = new DirectEnemyDownBlockState(this);
                    break;
                case Type.EnemyRightBlock:
                    blockState = new DirectEnemyRightBlockState(this);
                    break;
                case Type.EnemyLeftBlock:
                    blockState = new DirectEnemyLeftBlockState(this);
                    break;
                case Type.TeleportBlock:
                    blockState = new TeleportBlockState(this);
                    break;
                case Type.VerticalBlockWall:
                    blockState = new VerticalBlockWallState(this);
                    break;
                case Type.HorizontalBlockWall:
                    blockState = new HorizontalBlockWallState(this);
                    break;
            }
        }

        public IPhysics Physics
        {
            get { return null; }
        }

        public bool IsBumped
        {
            get { return isBumped; }

        }
    }
}
