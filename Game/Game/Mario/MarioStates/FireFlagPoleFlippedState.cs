using Game.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;

namespace Game.Mario.MarioStates
{
    class FireFlagPoleFlippedState : IMarioState
    {
        private IMario mario;

        public FireFlagPoleFlippedState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateFireFlagPoleFlippedSprite();
        }
        public void Update()
        {
            mario.Sprite.Update();
        }

        public void Left()
        {

        }

        public void Right()
        {
            mario.MarioState = new FireRightRunningState(mario);
        }

        public void Up()
        {

        }

        public void Down()
        {

        }

        public void Jump()
        {
            mario.MarioState = new FireLeftJumpingState(mario);
        }

        public void StopJumping()
        {
        }

        public void Flower()
        {

        }

        public void Mushroom()
        {
        }

        public void Star()
        {

        }

        public void PoleSlide()
        {

        }
        public void FlipAroundPole()
        {
            mario.MarioState = new FireFlagPoleFlippedState(mario);
        }

        public void Damage()
        {

        }

        public bool IsBigMario()
        {
            return true;
        }

        public bool IsFireMario()
        {
            return true;
        }

        public bool IsRight()
        {
            return false;
        }

        public void ToIdle()
        {
            mario.Right();
        }

        public bool IsJumping()
        {
            return false;
        }

        public void Run()
        {

        }

        public void StopRunning()
        {
            mario.Physics.VelocityMaximum = new Vector2(MarioStateConstants.WALKINGVELOCITYMAX, mario.Physics.VelocityMaximum.Y);
            mario.Physics.VelocityMinimum = new Vector2(MarioStateConstants.WALKINGVELOCITYMIN, mario.Physics.VelocityMinimum.Y);
        }
    }
}