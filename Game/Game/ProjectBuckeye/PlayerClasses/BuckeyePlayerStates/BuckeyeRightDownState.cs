using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.ProjectBuckeye.PlayerClasses;
using Game.Interfaces;
using Microsoft.Xna.Framework;
using Game.Utilities;
using Game.Utilities.Constants;
using Game.Music;

namespace Game.ProjectBuckeye.PlayerClasses.BuckeyePlayerStates
{
    public class BuckeyeRightDownState : IBuckeyePlayerState
    {
        IBuckeyePlayer buckeyePlayer;

        public BuckeyeRightDownState(IBuckeyePlayer buckeyePlayer)
        {
            this.buckeyePlayer = buckeyePlayer;
            this.buckeyePlayer.IsDead = true;
            this.buckeyePlayer.IsFacingRight = true;
            BackgroundThemeManager.PlayDeathTheme();
            buckeyePlayer.Sprite = SpriteFactories.BuckeyePlayerSpriteFactory.CreateBuckeyeRightDownSprite();
            buckeyePlayer.Physics.ResetPhysics();
        }

        public void Update()
        {
            buckeyePlayer.Sprite.Update();
        }

        public void Left()
        {
        }

        public void Right()
        {
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
        }

        public void Run()
        {
        }

        public void StopRunning()
        {
        }

        public void DownPlayer()
        {
        }

        public void ToIdle()
        {
        }

        bool IPlayerState.IsJumping()
        {
            return false;
        }
    }
}
