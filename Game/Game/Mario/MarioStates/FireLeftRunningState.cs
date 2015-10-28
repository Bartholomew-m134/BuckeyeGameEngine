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
    public class FireLeftRunningState : IMarioState
    {

        private IMario mario;

        public FireLeftRunningState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateFireLeftRunningSprite();
        }
        public void Update()
        {
            mario.Sprite.Update();
        }

        public void Left()
        {
            
            Vector2 acceleration = mario.Physics.Acceleration;
            acceleration.X = -2;
            mario.Physics.Acceleration = acceleration;
        }
        public void PoleSlide()
        {
            mario.MarioState = new FireFlagPoleSlidingState(mario);
        }

        public void Right()
        {
            mario.MarioState = new FireLeftIdleState(mario);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioState = new FireLeftCrouchingState(mario);
        }


        public void StopJumping()
        {
        }

        public void Jump()
        {
            
                mario.MarioState = new FireLeftJumpingState(mario);
            
        }

        public void Flower()
        {

        }

        public void Fire()
        {

        }

        public void Mushroom()
        {
        }

        public void Star()
        {
            
        }

        public void Damage()
        {
            mario.MarioState = new NormalLeftRunningState(mario);
        }

        public bool IsBig()
        {
            return true;
        }

        public bool IsFire()
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
            mario.Physics.VelocityMaximum = new Vector2(10, mario.Physics.VelocityMaximum.Y);
            mario.Physics.VelocityMinimum = new Vector2(-10, mario.Physics.VelocityMinimum.Y);

        }

        public void StopRunning()
        {
            mario.Physics.VelocityMaximum = new Vector2(6, mario.Physics.VelocityMaximum.Y);
            mario.Physics.VelocityMinimum = new Vector2(-6, mario.Physics.VelocityMinimum.Y);
        }
    }
}
