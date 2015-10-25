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
    public class NormalLeftJumpingState : IMarioState
    {

        private IMario mario;

        public NormalLeftJumpingState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftJumpingSprite();
            if (!mario.MarioState.IsJumping())
            {
                Vector2 velocity = this.mario.Physics.Velocity;
                velocity.Y = -11;
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
            mario.MarioState = new FireLeftJumpingState(mario);
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
            mario.MarioState = new SmallLeftJumpingState(mario);
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
            mario.MarioState = new NormalLeftIdleState(mario);
        }

        public bool IsJumping()
        {
            return true;
        }
    }
}
