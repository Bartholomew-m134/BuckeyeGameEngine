using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Interfaces;
using Microsoft.Xna.Framework;
using Game.Utilities;

namespace Game.Mario.MarioStates
{
    public class FireLeftIdleState : IMarioState
    {

        private IMario mario;

        public FireLeftIdleState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateFireLeftIdleSprite();
        }
        public void Update()
        {

            if (mario.Physics.Velocity.X < 0)
            {
                mario.Physics.DampenLeft();
            }

            mario.Sprite.Update();
        }

        public void Left()
        {
            mario.MarioState = new FireLeftRunningState(mario);
        }
        public void PoleSlide()
        {
            mario.MarioState = new FireFlagPoleSlidingState(mario);
        }

        public void Right()
        {
            mario.MarioState = new FireRightIdleState(mario);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioState = new FireLeftCrouchingState(mario);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            
                mario.MarioState = new FireLeftJumpingState(mario);
        }

        public void StopJumping()
        {
        }

        public void Flower()
        {

        }

        public void Mushroom()
        {
        }
        public void Star()
        {
            //mario = new StarMario(mario);
        }

        public void Damage()
        {
            mario.MarioState = new NormalLeftIdleState(mario);
        }

        public void Die()
        {
            mario.MarioState = new DeadMarioState(mario);
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
