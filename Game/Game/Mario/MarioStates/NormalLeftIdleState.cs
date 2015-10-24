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

            mario.Sprite.Update();
        }

        public void Left()
        {
            mario.MarioState = new NormalLeftRunningState(mario);
        }

        public void Right()
        {
            mario.MarioState = new NormalRightIdleState(mario);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioState = new NormalLeftCrouchingState(mario);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.MarioState = new NormalLeftJumpingState(mario);
        }

        public void Flower()
        {
            mario.MarioState = new FireLeftIdleState(mario);

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
            mario.MarioState = new SmallLeftIdleState(mario);
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
