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
            else if (mario.Physics.Velocity.X > 0)
            {
                mario.Physics.DampenRight();
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
        public void FlipAroundPole()
        {

        }

        public void Right()
        {
            if (mario.Physics.Velocity.X < 0)
            {
                mario.MarioState = new FireRightTwistState(mario);
            }
            else
            {
                mario.MarioState = new FireRightIdleState(mario);
            }
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioState = new FireLeftCrouchingState(mario);
            mario.VectorCoordinates += new Vector2(0, 16);
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

        }

        public void Damage()
        {
            mario.MarioState = new NormalLeftIdleState(mario);
        }

        public bool IsBigMario()
        {
            return true;
        }

        public bool IsFireMario()
        {
            return true;
        }

        public bool IsRight()
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
