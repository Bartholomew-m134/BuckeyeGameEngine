using Game.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Mario.MarioStates
{
    class NormalFlagPoleFlippedState : IMarioState
    {
        private IMario mario;

        public NormalFlagPoleFlippedState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateNormalFlagPoleFlippedSprite();
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
            mario.MarioState = new NormalRightRunningState(mario);
        }

        public void Up()
        {

        }

        public void Down()
        {

        }

        public void Jump()
        {
            mario.MarioState = new NormalLeftJumpingState(mario);
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
            mario.MarioState = new NormalFlagPoleFlippedState(mario);
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