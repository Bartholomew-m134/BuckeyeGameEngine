using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;

namespace Game.Mario.MarioStates
{
    public class NormalLeftCrouchingState : IMarioState
    {

        private IMario mario;

        public NormalLeftCrouchingState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftCrouchingSprite();
        }
        public void Update()
        {
            mario.Sprite.Update();
        }

        public void Left()
        {
            mario.MarioState = new NormalLeftRunningState(mario);
            mario.VectorCoordinates += new Vector2(0, -10);
        }

        public void Right()
        {
            mario.MarioState = new NormalRightRunningState(mario);
            mario.VectorCoordinates += new Vector2(0, -10);
        }

        public void Up()
        {
            mario.MarioState = new NormalLeftIdleState(mario);
        }

        public void Down()
        {
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.MarioState = new NormalLeftIdleState(mario);
            mario.VectorCoordinates += new Vector2(0, -10);
        }

        public void StopJumping()
        {
        }

        public void Flower()
        {
            mario.MarioState = new FireLeftCrouchingState(mario);
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
