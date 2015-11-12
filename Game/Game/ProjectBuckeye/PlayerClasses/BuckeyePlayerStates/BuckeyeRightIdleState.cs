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
    public class BuckeyeRightIdleState : IBuckeyePlayerState
    {
        IBuckeyePlayer buckeyePlayer;

        public BuckeyeRightIdleState(IBuckeyePlayer buckeyePlayer)
        {
            this.buckeyePlayer = buckeyePlayer;
            buckeyePlayer.Sprite = SpriteFactories.BuckeyePlayerSpriteFactory.CreateBuckeyeRightIdleSprite();
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
            buckeyePlayer.State = new BuckeyeLeftIdleState(buckeyePlayer);
        }

        public void Right()
        {
            buckeyePlayer.State = new BuckeyeRightMovementState(buckeyePlayer);
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
