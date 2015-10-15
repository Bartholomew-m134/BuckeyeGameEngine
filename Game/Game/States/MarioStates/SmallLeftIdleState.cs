using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    public class SmallLeftIdleState : IMarioState
    {

        private IMario mario;

        public SmallLeftIdleState(IMario mario)
        {
            this.mario = mario;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateSmallLeftIdleSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            mario.GetSetMarioState = new SmallLeftRunningState(mario);
        }

        public void Right()
        {
            mario.GetSetMarioState = new SmallRightIdleState(mario);
        }

        public void Up()
        {

        }

        public void Down()
        {
            Vector2 loc = mario.VectorCoordinates;
            loc.Y +=4;
            mario.VectorCoordinates = loc;
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
            mario.GetSetMarioState = new FireLeftIdleState(mario);
        }

        public void Mushroom()
        {
            mario.GetSetMarioState = new NormalLeftIdleState(mario);
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

        }
    }
}
