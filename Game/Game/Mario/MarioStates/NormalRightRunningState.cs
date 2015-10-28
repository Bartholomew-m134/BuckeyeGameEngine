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
    public class NormalRightRunningState : IMarioState
    {

        private IMario mario;

        public NormalRightRunningState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightRunningSprite();
        }
        public void Update()
        {
            mario.Sprite.Update();
        }

        public void Left()
        {
            mario.MarioState = new NormalLeftTwistState(mario);
        }

        public void Right()
        {
            
            Vector2 acceleration = mario.Physics.Acceleration;
            acceleration.X = 2;
            mario.Physics.Acceleration = acceleration;
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioState = new NormalRightCrouchingState(mario);
        }


        public void Jump()
        {      
             mario.MarioState = new NormalRightJumpingState(mario);
        }

        public void StopJumping()
        {
        }

        public void Flower()
        {
            mario.MarioState = new FireRightRunningState(mario);
        }

        public void Fire()
        {

        }
        public void PoleSlide()
        {
            mario.MarioState = new NormalFlagPoleSlidingState(mario);
        }

        public void Mushroom()
        {

        }

        public void Star()
        {
            
        }

        public void Damage()
        {
            mario.MarioState = new SmallRightRunningState(mario);
            mario.VectorCoordinates += new Vector2(0, 16);
        }

        public void Die()
        {
            mario.MarioState = new DeadMarioState(mario);
        }
        public bool IsBig()
        {
            return true;
        }

        public bool IsFire()
        {
            return false;
        }

        public void ToIdle()
        {
            mario.MarioState = new NormalRightIdleState(mario);
        }

        public bool IsJumping()
        {
            return false;
        }
    }
}
