using Game.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;

namespace Game.Mario.MarioStates
{
    class SmallFlagPoleFlippedState : IMarioState
    {
        private IMario mario;

        public SmallFlagPoleFlippedState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateSmallFlagPoleFlippedSprite();
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
            mario.MarioState = new SmallRightRunningState(mario);
        }

        public void Up()
        {

        }

        public void Down()
        {

        }

        public void Jump()
        {
            mario.MarioState = new SmallLeftJumpingState(mario);
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

        }

        public void Damage()
        {

        }

        public bool IsBigMario()
        {
            return false;
        }

        public bool IsFireMario()
        {
            return false;
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
            mario.Physics.VelocityMaximum = new Vector2(6, mario.Physics.VelocityMaximum.Y);
            mario.Physics.VelocityMinimum = new Vector2(-6, mario.Physics.VelocityMinimum.Y);
        }
    }
}