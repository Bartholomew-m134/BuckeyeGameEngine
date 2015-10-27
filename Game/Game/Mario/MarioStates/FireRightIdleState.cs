﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;

namespace Game.Mario.MarioStates
{
    public class FireRightIdleState : IMarioState
    {

        private IMario mario;

        public FireRightIdleState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateFireRightIdleSprite();
        }
        public void Update()
        {
            if (mario.Physics.Velocity.X > 0)
            {
                mario.Physics.DampenRight();
            }
            else if (mario.Physics.Velocity.X < 0)
            {
                mario.Physics.DampenLeft();
            }

            mario.Sprite.Update();
        }

        public void Left()
        {
            if (mario.Physics.Velocity.X > 0)
            {
                mario.MarioState = new FireLeftTwistState(mario);
            }
            else
            {
                mario.MarioState = new FireLeftIdleState(mario);
            }
        }

        public void Right()
        {
            mario.MarioState = new FireRightRunningState(mario);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioState = new FireRightCrouchingState(mario);
        }

        public void StopJumping()
        {
        }

        public void Jump()
        {
            
             mario.MarioState = new FireRightJumpingState(mario);
        }

        public void Flower()
        {

        }

        public void Fire()
        {

        }
        public void PoleSlide()
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
            mario.MarioState = new NormalRightIdleState(mario);
        }

        public bool IsBig()
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
    }
}
