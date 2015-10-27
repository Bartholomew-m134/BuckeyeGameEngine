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
    public class SmallLeftJumpingState : IMarioState
    {

        private IMario mario;

        public SmallLeftJumpingState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateSmallLeftJumpingSprite();
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
            mario.MarioState = new FireLeftJumpingState(mario);
            mario.VectorCoordinates += new Vector2(0, -16);
        }

        public void Fire()
        {

        }
        public void PoleSlide()
        {
            mario.MarioState = new SmallFlagPoleSlidingState(mario);
        }

        public void Mushroom()
        {
            mario.MarioState = new NormalLeftJumpingState(mario);
            mario.VectorCoordinates += new Vector2(0, -16);
        }

        public void Star()
        {
            
        }

        public void Damage()
        {
            mario.MarioState = new DeadMarioState(mario);
        }

        public void Die()
        {
            mario.MarioState = new DeadMarioState(mario);
        }
        public bool IsBig()
        {
            return false;
        }

        public void ToIdle()
        {
            mario.MarioState = new SmallLeftIdleState(mario);
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
