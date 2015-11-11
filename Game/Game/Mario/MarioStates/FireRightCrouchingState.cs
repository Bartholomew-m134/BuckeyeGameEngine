using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;

namespace Game.Mario.MarioStates
{
    public class FireRightCrouchingState : IMarioState
    {

        private IMario mario;

        public FireRightCrouchingState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateFireRightCrouchingSprite();
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
            mario.MarioState = new FireLeftCrouchingState(mario);
        }

        public void Right()
        {
           
        }

        public void Up()
        {
            mario.MarioState = new FireRightIdleState(mario);
        }

        public void Down()
        {
        }

        public void Jump()
        {
            mario.MarioState = new FireRightIdleState(mario);
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
            mario.MarioState = new NormalRightIdleState(mario);
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
