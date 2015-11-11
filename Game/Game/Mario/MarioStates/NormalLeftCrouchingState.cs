using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;

namespace Game.Mario.MarioStates
{
    public class NormalLeftCrouchingState : IMarioState
    {

        private IMario mario;

        public NormalLeftCrouchingState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftCrouchingSprite();
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

            mario.MarioState = new NormalRightCrouchingState(mario);
        }

        public void Up()
        {
            mario.MarioState = new NormalLeftIdleState(mario);
        }

        public void Down()
        {
        }


        public void Jump()
        {
            mario.MarioState = new NormalLeftIdleState(mario);
            mario.VectorCoordinates += new Vector2(0, -10);
        }

        public void StopJumping()
        {
        }

        public void Flower()
        {
            mario.MarioState = new FireLeftCrouchingState(mario);
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
            mario.VectorCoordinates += new Vector2(0, 16);
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
