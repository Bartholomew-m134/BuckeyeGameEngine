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
    public class SmallRightTwistState : IMarioState
    {

        private IMario mario;

        public SmallRightTwistState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightTwistSprite();
        }

        public void Update()
        {
            mario.Sprite.Update();

            if (mario.Physics.Velocity.X < 0)
            {
                mario.Physics.DampenLeft();
            }
            else if (mario.Physics.Velocity.X >= 0)
            {
                mario.MarioState = new SmallRightIdleState(mario);
            }
        }
        public void Left()
        {
            mario.MarioState = new SmallLeftIdleState(mario);
        }

        public void Right()
        {

        }

        public void Up()
        {

        }

        public void Down()
        {

        }

        public void Jump()
        {

            mario.MarioState = new SmallRightJumpingState(mario);
        }

        public void StopJumping()
        {
        }

        public void Flower()
        {
            mario.MarioState = new FireRightTwistState(mario);

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
            mario.MarioState = new NormalRightTwistState(mario);
        }

        public void Star()
        {

        }

        public void Damage()
        {
            mario.Die();
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
        }

        public bool IsJumping()
        {
            return false;
        }
    }
}