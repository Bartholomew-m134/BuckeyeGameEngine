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
    public class SmallRightIdleState : IMarioState
    {

        private IMario mario;

        public SmallRightIdleState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightIdleSprite();
        }
        public void Update()
        {
            mario.Sprite.Update();
        }

        public void Left()
        {
            mario.MarioState = new SmallLeftIdleState(mario);
        }

        public void Right()
        {
            mario.MarioState = new SmallRightRunningState(mario);
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
            mario.MarioState = new SmallRightJumpingState(mario);
        }

        public void Flower()
        {
            mario.MarioState = new FireRightIdleState(mario);
            mario.VectorCoordinates += new Vector2(0, -16);
        }

        public void Mushroom()
        {
            mario.MarioState = new NormalRightIdleState(mario);
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

        }

        public bool IsJumping()
        {
            return false;
        }
    }
}
