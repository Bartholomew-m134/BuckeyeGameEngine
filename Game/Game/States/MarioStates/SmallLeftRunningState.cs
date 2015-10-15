using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    public class SmallLeftRunningState : IMarioState
    {

        private IMario mario;

        public SmallLeftRunningState(IMario mario)
        {
            this.mario = mario;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateSmallLeftRunningSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            Vector2 loc = mario.VectorCoordinates;
            loc.X-=4;
            mario.VectorCoordinates = loc;
        }

        public void Right()
        {
            mario.GetSetMarioState = new SmallLeftIdleState(mario);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.GetSetMarioState = new SmallLeftIdleState(mario);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.GetSetMarioState = new SmallLeftJumpingState(mario);
        }

        public void Flower()
        {
            mario.GetSetMarioState = new FireLeftRunningState(mario);
        }

        public void Mushroom()
        {
            mario.GetSetMarioState = new NormalLeftRunningState(mario);
        }

        public void Star()
        {
            //mario = new StarMario(mario);
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
            mario.Right();
        }
    }
}
