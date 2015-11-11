using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities.Constants;

namespace Game.Mario.MarioStates
{
    public class FireLeftCrouchingState : IMarioState
    {

        private IMario mario;

        public FireLeftCrouchingState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateFireLeftCrouchingSprite();
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
           
        }

        public void Right()
        {
            mario.MarioState = new FireRightCrouchingState(mario);
        }

        public void Up()
        {
            mario.MarioState = new FireLeftIdleState(mario);
        }

        public void Down()
        {
        }

        public void Jump()
        {
            mario.MarioState = new FireLeftIdleState(mario);
            mario.VectorCoordinates += new Vector2(0, -10);
        }

        public void StopJumping()
        {
        }

        public void Flower()
        {

        }

        public void PoleSlide()
        {
            mario.MarioState = new FireFlagPoleSlidingState(mario);
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
