using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;

namespace Game.Mario.MarioStates
{
    public class NormalRightIdleState : IMarioState
    {

        private IMario mario;

        public NormalRightIdleState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightIdleSprite();
        }
        public void Update()
        {
            if (mario.Physics.Velocity.X > 0)
            {
                mario.Physics.DampenRight();
            }

            mario.Sprite.Update();
        }

        public void Left()
        {
            mario.MarioState = new NormalLeftIdleState(mario);
        }

        public void Right()
        {
            mario.MarioState = new NormalRightRunningState(mario);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioState = new NormalRightCrouchingState(mario);
        }

        public void Jump()
        {
          
                mario.MarioState = new NormalRightJumpingState(mario);
        }

        public void StopJumping()
        {
        }

        public void Flower()
        {
            mario.MarioState = new FireRightIdleState(mario);
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
            
        }

        public void Damage()
        {
            mario.MarioState = new SmallRightIdleState(mario);
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
        }

        public bool IsJumping()
        {
            return false;
        }
    }
}
