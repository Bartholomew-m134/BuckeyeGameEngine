﻿using System;
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
    public class BuckeyeLeftMovementState : IBuckeyePlayerState
    {
        IBuckeyePlayer buckeyePlayer;

        public BuckeyeLeftMovementState(IBuckeyePlayer buckeyePlayer)
        {
            this.buckeyePlayer = buckeyePlayer;
            buckeyePlayer.Sprite = SpriteFactories.BuckeyePlayerSpriteFactory.CreateBuckeyeLeftMovementSprite();
            this.buckeyePlayer.IsFacingRight = false;
        }

        public void Update()
        {
            buckeyePlayer.Sprite.Update();
        }

        public void Left()
        {
            Vector2 acceleration = buckeyePlayer.Physics.Acceleration;
            acceleration.X = BuckeyePlayerStateConstants.NEGATIVE_RUNNING_X_ACCELERATION;
            buckeyePlayer.Physics.Acceleration = acceleration;
        }

        public void Right()
        {
            buckeyePlayer.State = new BuckeyeLeftIdleState(buckeyePlayer);
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

        public void ToIdle()
        {
            buckeyePlayer.State = new BuckeyeLeftIdleState(buckeyePlayer);
        }

        public bool IsJumping()
        {
            return false;
        }
    }
}
