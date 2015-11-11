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
    public class NormalLeftIdleState : IMarioState
    {

        private IMario mario;

        public NormalLeftIdleState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftIdleSprite();
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
            mario.MarioState = new NormalLeftRunningState(mario);
        }

        public void Right()
        {
            if (mario.Physics.Velocity.X < 0)
            {
                mario.MarioState = new NormalRightTwistState(mario);
            }
            else
            {
                mario.MarioState = new NormalRightIdleState(mario);
            }
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioState = new NormalLeftCrouchingState(mario);
            mario.VectorCoordinates += new Vector2(0, 16);
            
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
            mario.MarioState = new FireLeftIdleState(mario);

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
