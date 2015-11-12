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
    public class BuckeyeRightMovementState : IBuckeyePlayerState
    {
        IBuckeyePlayer buckeyePlayer;

        public BuckeyeRightMovementState(IBuckeyePlayer buckeyePlayer)
        {
            this.buckeyePlayer = buckeyePlayer;
            buckeyePlayer.Sprite = SpriteFactories.BuckeyePlayerSpriteFactory.CreateBuckeyeRightMovementSprite();
        }

        public void Update()
        {
            buckeyePlayer.Sprite.Update();
        }

        public void Left()
        {
            buckeyePlayer.State = new BuckeyeRightIdleState(buckeyePlayer);
        }

        public void Right()
        {
            Vector2 acceleration = buckeyePlayer.Physics.Acceleration;
            acceleration.X = BuckeyePlayerStateConstants.POSITIVE_RUNNING_X_ACCELERATION;
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
            buckeyePlayer.State = new BuckeyeRightJumpingState(buckeyePlayer);
        }

        public void StopJumping()
        {
        }

        public void Run()
        {
            buckeyePlayer.Physics.VelocityMaximum = new Vector2(BuckeyePlayerStateConstants.RUNNING_VELOCITY_MAX, buckeyePlayer.Physics.VelocityMaximum.Y);
            buckeyePlayer.Physics.VelocityMinimum = new Vector2(BuckeyePlayerStateConstants.RUNNING_VELOCITY_MIN, buckeyePlayer.Physics.VelocityMinimum.Y);
        }

        public void StopRunning()
        {
            buckeyePlayer.Physics.VelocityMaximum = new Vector2(BuckeyePlayerStateConstants.WALKING_VELOCITY_MAX, buckeyePlayer.Physics.VelocityMaximum.Y);
            buckeyePlayer.Physics.VelocityMinimum = new Vector2(BuckeyePlayerStateConstants.WALKING_VELOCITY_MIN, buckeyePlayer.Physics.VelocityMinimum.Y);
        }

        public void DownPlayer()
        {
            buckeyePlayer.State = new BuckeyeRightDownState(buckeyePlayer);
        }


        public bool IsJumping
        {
            get { return false; }
        }
    }
}
