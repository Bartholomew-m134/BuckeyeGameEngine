using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;

namespace Game.Mario.MarioStates
{
    public class FireLeftTwistState : IMarioState
    {

        private IMario mario;

        public FireLeftTwistState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateFireLeftTwistSprite();
        }

        public void Update()
        {
            mario.Sprite.Update();

            if (mario.Physics.Velocity.X > 0)
            {
                mario.Physics.DampenRight();
            }
            else if (mario.Physics.Velocity.X <= 0)
            {
                mario.MarioState = new FireLeftIdleState(mario);
            }
        }
        public void Left()
        {

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

        public void Fire()
        {

        }
        public void PoleSlide()
        {
            mario.MarioState = new FireFlagPoleSlidingState(mario);
        }

        public void Mushroom()
        {

        }

        public void Star()
        {

        }

        public void Damage()
        {
            mario.MarioState = new NormalLeftTwistState(mario);
        }

        public bool IsBig()
        {
            return true;
        }

        public bool IsFire()
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
            mario.Physics.VelocityMaximum = new Vector2(6, mario.Physics.VelocityMaximum.Y);
            mario.Physics.VelocityMinimum = new Vector2(-6, mario.Physics.VelocityMinimum.Y);
        }
    }
}