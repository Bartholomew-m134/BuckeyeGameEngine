using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;

namespace Game.Mario.MarioStates
{
    public class NormalRightCrouchingState : IMarioState
    {

        private IMario mario;

        public NormalRightCrouchingState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightCrouchingSprite();
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
            
        }

        public void Down()
        {
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.MarioState = new NormalRightIdleState(mario);
            mario.VectorCoordinates += new Vector2(0, -10);
        }

        public void Flower()
        {
            mario.MarioState = new FireRightCrouchingState(mario);
        }

        public void Mushroom()
        {

        }

        public void Star()
        {
            //mario = new StarMario((MarioInstance)mario);
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
