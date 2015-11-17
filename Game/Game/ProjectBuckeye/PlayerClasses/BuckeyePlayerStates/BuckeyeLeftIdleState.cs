using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.ProjectBuckeye.PlayerClasses;
using Game.Interfaces;
using Microsoft.Xna.Framework;
using Game.Utilities;
using Game.Utilities.Constants;

namespace Game.ProjectBuckeye.PlayerClasses.BuckeyePlayerStates
{
    public class BuckeyeLeftIdleState : IBuckeyePlayerState
    {
        IBuckeyePlayer buckeyePlayer;

        public BuckeyeLeftIdleState(IBuckeyePlayer buckeyePlayer)
        {
            this.buckeyePlayer = buckeyePlayer;
            buckeyePlayer.Sprite = SpriteFactories.BuckeyePlayerSpriteFactory.CreateBuckeyeLeftIdleSprite();
        }

        public void Update()
        {
            if (buckeyePlayer.Physics.Velocity.X < 0)
            {
                buckeyePlayer.Physics.DampenLeft();
            }
            else if (buckeyePlayer.Physics.Velocity.X > 0)
            {
                buckeyePlayer.Physics.DampenRight();
            }

            buckeyePlayer.Sprite.Update();
        }

        public void Left()
        {
            buckeyePlayer.State = new BuckeyeLeftMovementState(buckeyePlayer);
        }

        public void Right()
        {
            buckeyePlayer.State = new BuckeyeRightIdleState(buckeyePlayer);
        }

        public void Up()
        {
        }

        public void Down()
        {
        }

        public void Jump()
        {
            buckeyePlayer.State = new BuckeyeLeftJumpingState(buckeyePlayer);
        }

        public void StopJumping()
        {
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

        public void ToIdle()
        {
            buckeyePlayer.State = new BuckeyeLeftIdleState(buckeyePlayer);
        }

        bool IPlayerState.IsJumping()
        {
            return false;
        }
    }
}
