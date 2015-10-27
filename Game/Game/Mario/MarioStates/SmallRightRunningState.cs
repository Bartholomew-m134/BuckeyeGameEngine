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
    public class SmallRightRunningState : IMarioState
    {

        private IMario mario;

        public SmallRightRunningState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightRunningSprite();
        }
        public void Update()
        {
            mario.Sprite.Update();
        }

        public void Left()
        {
            mario.MarioState = new SmallRightIdleState(mario);
        }

        public void Right()
        {
            
            Vector2 acceleration =mario.Physics.Acceleration;
            acceleration.X = 2;
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
         
                mario.MarioState = new SmallRightJumpingState(mario);
        }

        public void StopJumping() 
        {
        }

        public void Flower()
        {
            mario.MarioState = new FireRightRunningState(mario);
            mario.VectorCoordinates += new Vector2(0, -16);
        }
        public void PoleSlide()
        {
            mario.MarioState = new SmallFlagPoleSlidingState(mario);
        }
        public void Mushroom()
        {
            mario.MarioState = new NormalRightRunningState(mario);
            mario.VectorCoordinates += new Vector2(0, -16);
        }

        public void Star()
        {
            
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
            mario.Left();
        }

        public bool IsJumping()
        {
            return false;
        }
    }
}
