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
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightJumpingSprite();
            Vector2 velocity = this.mario.Physics.Velocity;
            velocity.Y = -11;
            this.mario.Physics.Velocity = velocity;
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
            Vector2 velocity = mario.Physics.Velocity;
            Vector2 acceleration = mario.Physics.Acceleration;

            if (velocity.Y < 0)
            {
                acceleration.Y = 1;
                mario.Physics.Acceleration = acceleration;
            }
            else {
                velocity.Y = 5;
                acceleration.Y = 0;
                mario.Physics.Velocity = velocity;
                mario.Physics.Acceleration = acceleration;
            }

        }

        public void Flower()
        {
            mario.MarioState = new FireRightJumpingState(mario);
            mario.VectorCoordinates += new Vector2(0, -16);
        }

        public void Mushroom()
        {
            mario.MarioState = new NormalRightJumpingState(mario);
            mario.VectorCoordinates += new Vector2(0, -16);
        }

        public void Star()
        {
            //mario = new StarMario(mario);
        }

        public void Damage()
        {
            mario.MarioState = new DeadMarioState(mario);
        }

        public void Die()
        {
            mario.MarioState = new DeadMarioState(mario);
        }
        public bool IsBig()
        {
            return false;
        }

        public void ToIdle()
        {
            mario.MarioState = new SmallRightIdleState(mario);
        }

        public bool IsJumping()
        {
            return true;
        }
    }
}
