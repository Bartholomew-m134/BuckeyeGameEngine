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
    public class NormalRightJumpingState : IMarioState
    {

        private IMario mario;

        public NormalRightJumpingState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightJumpingSprite();
            if (!mario.MarioState.IsJumping())
            {
                Vector2 velocity = this.mario.Physics.Velocity;
                velocity.Y = -12;
                this.mario.Physics.Velocity = velocity;
            }
        }
        public void Update()
        {   
            mario.Sprite.Update();
        }

        public void Left()
        {
            Vector2 acceleration = mario.Physics.Acceleration;
            acceleration.X = -2;
            mario.Physics.Acceleration = acceleration;
        }

        public void Right()
        {
            
            Vector2 acceleration = mario.Physics.Acceleration;
            acceleration.X = 2;
            mario.Physics.Acceleration = acceleration;
        }

        public void Up()
        {

        }

        public void Down()
        {
            
        }

        public void Land()
        {
            
        }

        public void Jump()
        {
            
        }

        public void StopJumping()
        {
            if (mario.Physics.Velocity.Y < 0)
            {
                mario.Physics.ResetY();
            }
        }

        public void Flower()
        {
            mario.MarioState = new FireRightJumpingState(mario);
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
            //mario = new StarMario(mario);
        }

        public void Damage()
        {
            mario.MarioState = new SmallRightJumpingState(mario);
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
            mario.MarioState = new NormalRightIdleState(mario);
        }

        public bool IsJumping()
        {
            return true;
        }
    }
}
