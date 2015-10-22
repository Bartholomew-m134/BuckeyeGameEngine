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
    public class FireLeftJumpingState : IMarioState
    {

        private IMario mario;

        public FireLeftJumpingState(IMario mario)
        {
            this.mario = mario;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateFireLeftJumpingSprite();
            Vector2 velocity = this.mario.Physics.GetSetVelocity;
            velocity.Y = -11;
            this.mario.Physics.GetSetVelocity = velocity;
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
          
            Vector2 acceleration = mario.Physics.GetSetAcceleration;
            acceleration.X = -2;
            mario.Physics.GetSetAcceleration = acceleration;
        }

        public void Right()
        {
            Vector2 acceleration = mario.Physics.GetSetAcceleration;
            acceleration.X = 2;
            mario.Physics.GetSetAcceleration = acceleration;
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.GetSetMarioState = new FireLeftIdleState(mario);
        }

        public void Land()
        {
            
        }

        public void Jump()
        {
            Vector2 velocity = mario.Physics.GetSetVelocity;
            Vector2 acceleration = mario.Physics.GetSetAcceleration;

            if (velocity.Y < 0)
            {
                acceleration.Y = 1;
                mario.Physics.GetSetAcceleration = acceleration;
            }
            else
            {
                velocity.Y = 5;
                acceleration.Y = 0;
                mario.Physics.GetSetVelocity = velocity;
                mario.Physics.GetSetAcceleration = acceleration;
            }
        }

        public void Flower()
        {

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
            mario.GetSetMarioState = new NormalLeftJumpingState(mario);
        }

        public void Die()
        {
            mario.GetSetMarioState = new DeadMarioState(mario);
        }
        public bool IsBig()
        {
            return true;
        }

        public void ToIdle()
        {

        }
    }
}
