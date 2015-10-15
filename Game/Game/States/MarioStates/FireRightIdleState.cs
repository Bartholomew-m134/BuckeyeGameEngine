using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    public class FireRightIdleState : IMarioState
    {

        private IMario mario;

        public FireRightIdleState(IMario mario)
        {
            this.mario = mario;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateFireRightIdleSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            mario.GetSetMarioState = new FireLeftIdleState(mario);
        }

        public void Right()
        {
            mario.GetSetMarioState = new FireRightRunningState(mario);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.GetSetMarioState = new FireRightCrouchingState(mario);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.GetSetMarioState = new FireRightJumpingState(mario);
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
            mario.GetSetMarioState = new NormalRightIdleState(mario);
        }

        public void Die()
        {
            mario.GetSetMarioState = new DeadMarioState(mario);
        }
        public bool IsBig()
        {
            return true;
        }

        public void ToIdle()
        {

        }
    }
}
