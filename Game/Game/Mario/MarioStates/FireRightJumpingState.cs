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
    public class FireRightJumpingState : IMarioState
    {

        private IMario mario;

        public FireRightJumpingState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateFireRightJumpingSprite();
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
            acceleration.X = -1;
            mario.Physics.Acceleration = acceleration;
        }

        public void Right()
        {
        
            Vector2 acceleration = mario.Physics.Acceleration;
            acceleration.X = 1;
            mario.Physics.Acceleration = acceleration;
        }

        public void Up()
        {

        }

        public void Down()
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
            mario.MarioState = new NormalRightJumpingState(mario);
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
            mario.MarioState = new FireRightIdleState(mario);
        }

        public bool IsJumping()
        {
            return true;
        }
    }
}
