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
    public class NormalLeftRunningState : IMarioState
    {

        private IMario mario;

        public NormalLeftRunningState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftRunningSprite();
        }
        public void Update()
        {
            mario.Sprite.Update();
        }

        public void Left()
        {
            
            Vector2 acceleration = mario.Physics.Acceleration;
            acceleration.X = MarioStateConstants.NEGATIVERUNNINGXACCELERATION;
            mario.Physics.Acceleration = acceleration;
        }

        public void Right()
        {
            mario.MarioState = new NormalRightTwistState(mario);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioState = new NormalLeftCrouchingState(mario);
            mario.VectorCoordinates += new Vector2(0, MarioStateConstants.SMALLORCROUCHINGOFFSET);
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
            mario.MarioState = new FireLeftRunningState(mario);
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
            mario.MarioState = new SmallLeftRunningState(mario);
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
            return false;
        }

        public void ToIdle()
        {
            mario.MarioState = new NormalLeftIdleState(mario);
        }

        public bool IsJumping()
        {
            return false;
        }

        public void Run()
        {
            mario.Physics.VelocityMaximum = new Vector2(MarioStateConstants.RUNNINGVELOCITYMAX, mario.Physics.VelocityMaximum.Y);
            mario.Physics.VelocityMinimum = new Vector2(MarioStateConstants.RUNNINGVELOCITYMIN, mario.Physics.VelocityMinimum.Y);

        }

        public void StopRunning()
        {
            mario.Physics.VelocityMaximum = new Vector2(MarioStateConstants.WALKINGVELOCITYMAX, mario.Physics.VelocityMaximum.Y);
            mario.Physics.VelocityMinimum = new Vector2(MarioStateConstants.WALKINGVELOCITYMIN, mario.Physics.VelocityMinimum.Y);
        }
    }
}
