﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;

namespace Game.Mario.MarioStates
{
    public class SmallLeftTwistState : IMarioState
    {

        private IMario mario;

        public SmallLeftTwistState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateSmallLeftTwistSprite();
        }

        public void Update()
        {
            mario.Sprite.Update();

            if (mario.Physics.Velocity.X > 0)
            {
                mario.Physics.DampenRight();
            }
            else if (mario.Physics.Velocity.X <= 0)
            {
                mario.MarioState = new SmallLeftIdleState(mario);
            }
        }
        public void Left()
        {

        }

        public void Right()
        {
            mario.MarioState = new SmallRightIdleState(mario);
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
            mario.MarioState = new FireLeftTwistState(mario);

        }

        public void PoleSlide()
        {
            mario.MarioState = new SmallFlagPoleSlidingState(mario);
        }
        public void FlipAroundPole()
        {

        }

        public void Mushroom()
        {
            mario.MarioState = new NormalLeftTwistState(mario);
            mario.VectorCoordinates += new Vector2(0, -16);
        }

        public void Star()
        {

        }

        public void Damage()
        {
            ScoreManager.ResetScore();
            mario.MarioState = new DeadMarioState(mario);
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