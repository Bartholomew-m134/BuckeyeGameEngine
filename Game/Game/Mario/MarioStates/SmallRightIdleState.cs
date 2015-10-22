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
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightIdleSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            mario.GetSetMarioState = new SmallLeftIdleState(mario);
        }

        public void Right()
        {
            mario.GetSetMarioState = new SmallRightRunningState(mario);
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
            mario.GetSetMarioState = new SmallRightJumpingState(mario);
        }

        public void Flower()
        {
            mario.GetSetMarioState = new FireRightIdleState(mario);
        }

        public void Mushroom()
        {
            mario.GetSetMarioState = new NormalRightIdleState(mario);
        }

        public void Star()
        {
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
