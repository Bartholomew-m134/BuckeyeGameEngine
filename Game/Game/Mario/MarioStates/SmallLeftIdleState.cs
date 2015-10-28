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
    public class SmallLeftIdleState : IMarioState
    {

        private IMario mario;

        public SmallLeftIdleState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateSmallLeftIdleSprite();
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
            mario.MarioState = new SmallLeftRunningState(mario);
        }

        public void Right()
        {
            if (mario.Physics.Velocity.X < 0)
            {
                mario.MarioState = new SmallRightTwistState(mario);
            }
            else
            {
                mario.MarioState = new SmallRightIdleState(mario);
            }
        }

        public void Up()
        {

        }

        public void Down()
        {
        }

        public void Jump()
        {     
            mario.MarioState = new SmallLeftJumpingState(mario);
        }

        public void StopJumping()
        {
        }

        public void Flower()
        {
            mario.MarioState = new FireLeftIdleState(mario);
            mario.VectorCoordinates += new Vector2(0, -16);
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
                mario.MarioState = new NormalLeftIdleState(mario);
                mario.VectorCoordinates += new Vector2(0, -16);
        }

        public void Star()
        {
            
        }

        public void Damage()
        {
            mario.MarioState = new DeadMarioState(mario);
        }

        public bool IsBig()
        {
            return false;
        }

        public bool IsFire()
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
