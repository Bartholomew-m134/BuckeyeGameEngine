﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;
using Game.SoundEffects;
using Game.Utilities.Constants;

namespace Game.Mario.MarioStates
{
    public class NormalRightJumpingState : IMarioState
    {

        private IMario mario;

        public NormalRightJumpingState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightJumpingSprite();
            if (!mario.MarioState.IsJumping())
            {
                Vector2 velocity = this.mario.Physics.Velocity;
                velocity.Y = MarioStateConstants.INITIALJUMPVELOCITY;
                this.mario.Physics.Velocity = velocity;
                SoundEffectManager.SuperMarioJumpEffect();
            }
        }
        public void Update()
        {   
            mario.Sprite.Update();
        }

        public void Left()
        {
            Vector2 acceleration = mario.Physics.Acceleration;
            acceleration.X = MarioStateConstants.NEGATIVEJUMPINGXACCELERATION;
            mario.Physics.Acceleration = acceleration;
        }

        public void Right()
        {
            
            Vector2 acceleration = mario.Physics.Acceleration;
            acceleration.X = MarioStateConstants.POSITIVEJUMPINGXACCELERATION;
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
            mario.MarioState = new FireRightJumpingState(mario);
        }

        public void PoleSlide()
        {
            mario.MarioState = new NormalFlagPoleSlidingState(mario);
        }
        public void FlipAroundPole()
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
            mario.MarioState = new SmallRightJumpingState(mario);
            mario.VectorCoordinates += new Vector2(0, MarioStateConstants.SMALLORCROUCHINGOFFSET);
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
            return true;
        }

        public void ToIdle()
        {
            mario.MarioState = new NormalRightIdleState(mario);
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
            mario.Physics.VelocityMaximum = new Vector2(MarioStateConstants.WALKINGVELOCITYMAX, mario.Physics.VelocityMaximum.Y);
            mario.Physics.VelocityMinimum = new Vector2(MarioStateConstants.WALKINGVELOCITYMIN, mario.Physics.VelocityMinimum.Y);
        }
    }
}
