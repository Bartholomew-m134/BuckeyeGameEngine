﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities.Constants;

namespace Game.Mario.MarioStates
{
    public class NormalRightCrouchingState : IMarioState
    {

        private IMario mario;

        public NormalRightCrouchingState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightCrouchingSprite();
        }
        public void Update()
        {
            mario.Sprite.Update();

            if (mario.Physics.Velocity.X > 0)
            {
                mario.Physics.DampenRight();
            }
            else if (mario.Physics.Velocity.X < 0)
            {
                mario.Physics.DampenLeft();
            }
        }

        public void Left()
        {
            mario.MarioState = new NormalLeftCrouchingState(mario);
        }

        public void Right()
        {
            
        }

        public void Up()
        {
            mario.MarioState = new NormalRightIdleState(mario);
        }

        public void Down()
        {
        }


        public void Jump()
        {
            mario.MarioState = new NormalRightIdleState(mario);
            mario.VectorCoordinates += new Vector2(0, MarioStateConstants.STANDUPOFFSET);
        }

        public void StopJumping()
        {
        }

        public void Flower()
        {
            mario.MarioState = new FireRightCrouchingState(mario);
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
            mario.MarioState = new SmallLeftIdleState(mario);
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
