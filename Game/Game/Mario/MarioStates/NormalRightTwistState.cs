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
    public class NormalRightTwistState : IMarioState
    {

        private IMario mario;

        public NormalRightTwistState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightTwistSprite();
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
                mario.MarioState = new NormalRightIdleState(mario);
            }
        }
        public void Left()
        {
            mario.MarioState = new NormalLeftIdleState(mario);
        }

        public void Right()
        {
            
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioState = new NormalLeftCrouchingState(mario);
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
            mario.MarioState = new FireLeftTwistState(mario);

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
            mario.MarioState = new SmallRightTwistState(mario);
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
