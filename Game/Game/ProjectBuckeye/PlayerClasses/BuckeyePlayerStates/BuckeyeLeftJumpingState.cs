using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.ProjectBuckeye.PlayerClasses;
using Game.Interfaces;
using Microsoft.Xna.Framework;
using Game.Utilities;
using Game.Utilities.Constants;
using Game.SoundEffects;

namespace Game.ProjectBuckeye.PlayerClasses.BuckeyePlayerStates
{
    public class BuckeyeLeftJumpingState : IBuckeyePlayerState
    {
        IBuckeyePlayer buckeyePlayer;

        public BuckeyeLeftJumpingState(IBuckeyePlayer buckeyePlayer)
        {
            this.buckeyePlayer = buckeyePlayer;
            buckeyePlayer.Sprite = SpriteFactories.BuckeyePlayerSpriteFactory.CreateBuckeyeLeftJumpingSprite();
            if (!buckeyePlayer.State.IsJumping)
            {
                Vector2 velocity = this.buckeyePlayer.Physics.Velocity;
                velocity.Y = BuckeyePlayerStateConstants.INITIAL_JUMP_VELOCITY;
                this.buckeyePlayer.Physics.Velocity = velocity;
                SoundEffectManager.SmallMarioJumpEffect();
            }
        }

        public void Update()
        {
            buckeyePlayer.Sprite.Update();
        }

        public void Left()
        {
            Vector2 acceleration = buckeyePlayer.Physics.Acceleration;
            acceleration.X = BuckeyePlayerStateConstants.NEGATIVE_JUMPING_X_ACCELERATION;
            buckeyePlayer.Physics.Acceleration = acceleration;
        }

        public void Right()
        {
            Vector2 acceleration = buckeyePlayer.Physics.Acceleration;
            acceleration.X = BuckeyePlayerStateConstants.POSITIVE_JUMPING_X_ACCELERATION;
            buckeyePlayer.Physics.Acceleration = acceleration;
        }

        public void Up()
        {
        }

        public void Down()
        {
        }

        public void Jump()
        {
        }

        public void StopJumping()
        {
            if (buckeyePlayer.Physics.Velocity.Y < 0)
            {
                buckeyePlayer.Physics.ResetY();
            }
        }

        public void Run()
        {
        }

        public void StopRunning()
        {
            buckeyePlayer.Physics.VelocityMaximum = new Vector2(BuckeyePlayerStateConstants.WALKING_VELOCITY_MAX, buckeyePlayer.Physics.VelocityMaximum.Y);
            buckeyePlayer.Physics.VelocityMinimum = new Vector2(BuckeyePlayerStateConstants.WALKING_VELOCITY_MIN, buckeyePlayer.Physics.VelocityMinimum.Y);
        }

        public void DownPlayer()
        {
            buckeyePlayer.State = new BuckeyeLeftDownState(buckeyePlayer);
        }


        public bool IsJumping
        {
            get { return true; }
        }
    }
}
