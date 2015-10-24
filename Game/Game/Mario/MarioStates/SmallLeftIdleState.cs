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
    public class SmallLeftIdleState : IMarioState
    {

        private IMario mario;

        public SmallLeftIdleState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateSmallLeftIdleSprite();
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
            mario.MarioState = new SmallLeftRunningState(mario);
        }

        public void Right()
        {
            mario.MarioState = new SmallRightIdleState(mario);
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
            mario.MarioState = new SmallLeftJumpingState(mario);
        }

        public void Flower()
        {
            mario.MarioState = new FireLeftIdleState(mario);
            mario.VectorCoordinates += new Vector2(0, -16);
        }

        public void Mushroom()
        {
            mario.MarioState = new NormalLeftIdleState(mario);
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
        }

        public bool IsJumping()
        {
            return false;
        }
    }
}
