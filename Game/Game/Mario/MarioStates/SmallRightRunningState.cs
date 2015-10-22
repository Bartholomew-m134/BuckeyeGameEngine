using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;

namespace Game.Mario.MarioStates
{
    public class SmallRightRunningState : IMarioState
    {

        private IMario mario;

        public SmallRightRunningState(IMario mario)
        {
            this.mario = mario;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightRunningSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            mario.GetSetMarioState = new SmallRightIdleState(mario);
        }

        public void Right()
        {
            mario.
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.GetSetMarioState = new SmallRightIdleState(mario);
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
            mario.GetSetMarioState = new FireRightRunningState(mario);
        }

        public void Mushroom()
        {
            mario.GetSetMarioState = new NormalRightRunningState(mario);
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
            mario.Left();
        }
    }
}
