﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;

namespace Game.Mario.MarioStates
{
    public class FireLeftJumpingState : IMarioState
    {

        private IMario mario;

        public FireLeftJumpingState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateFireLeftJumpingSprite();
            if (!mario.MarioState.IsJumping())
            {
                Vector2 velocity = this.mario.Physics.Velocity;
                velocity.Y = -12;
                this.mario.Physics.Velocity = velocity;
            }
        }
        public void Update()
        {
            mario.Sprite.Update();
        }

        public void Left()
        {
          
            Vector2 acceleration = mario.Physics.Acceleration;
            acceleration.X = -1;
            mario.Physics.Acceleration = acceleration;
        }

        public void Right()
        {
            Vector2 acceleration = mario.Physics.Acceleration;
            acceleration.X = 1;
            mario.Physics.Acceleration = acceleration;
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioState = new FireLeftIdleState(mario);
        }

        public void Jump()
        {
           
        }

        public void StopJumping() 
        {
            if (mario.Physics.Velocity.Y < 0)
            {
                mario.Physics.ResetY();
            }
        }
        public void Flower()
        {

        }

        public void PoleSlide()
        {
            mario.MarioState = new FireFlagPoleSlidingState(mario);
        }

        public void Mushroom()
        {
        }

        public void Star()
        {

        }

        public void Damage()
        {
            mario.MarioState = new NormalLeftJumpingState(mario);
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
            mario.MarioState = new FireLeftIdleState(mario);
        }

        public bool IsJumping()
        {
            return true;
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
