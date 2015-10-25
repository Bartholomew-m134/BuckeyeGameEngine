using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;

namespace Game.Mario.MarioStates
{
    public class FireRightCrouchingState : IMarioState
    {

        private IMario mario;

        public FireRightCrouchingState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateFireRightCrouchingSprite();
        }
        public void Update()
        {
            mario.Sprite.Update();
        }

        public void Left()
        {
            mario.MarioState = new FireLeftRunningState(mario);
            mario.VectorCoordinates += new Vector2(0, -10);
        }

        public void Right()
        {
            mario.MarioState = new FireRightRunningState(mario);
            mario.VectorCoordinates += new Vector2(0, -10);
        }

        public void Up()
        {
            mario.MarioState = new FireRightIdleState(mario);
        }

        public void Down()
        {
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.MarioState = new FireRightIdleState(mario);
            mario.VectorCoordinates += new Vector2(0, -10);
        }

        public void StopJumping()
        {
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
            mario.MarioState = new NormalRightIdleState(mario);
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
