﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;

namespace Game.Mario.MarioStates
{
    public class SmallRightJumpingState : IMarioState
    {

        private IMario mario;

        public SmallRightJumpingState(IMario mario)
        {
            this.mario = mario;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightJumpingSprite();
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
            else {
                velocity.Y = 5;
                acceleration.Y = 0;
                mario.Physics.GetSetVelocity = velocity;
                mario.Physics.GetSetAcceleration = acceleration;
            }

        }

        public void Flower()
        {
            mario.GetSetMarioState = new FireRightJumpingState(mario);
        }

        public void Mushroom()
        {
            mario.GetSetMarioState = new NormalRightJumpingState(mario);
        }

        public void Star()
        {
            //mario = new StarMario(mario);
        }

        public void Damage()
        {
            mario.GetSetMarioState = new DeadMarioState(mario);
        }

        public void Die()
        {
            mario.GetSetMarioState = new DeadMarioState(mario);
        }
        public bool IsBig()
        {
            return false;
        }

        public void ToIdle()
        {

        }
    }
}
