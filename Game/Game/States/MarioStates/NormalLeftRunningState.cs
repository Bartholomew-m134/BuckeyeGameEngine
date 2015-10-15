using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    public class NormalLeftRunningState : IMarioState
    {

        private IMario mario;

        public NormalLeftRunningState(IMario mario)
        {
            this.mario = mario;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftRunningSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            Vector2 loc = mario.VectorCoordinates;
            loc.X -= 4;
            mario.VectorCoordinates = loc;
        }

        public void Right()
        {
            mario.GetSetMarioState = new NormalLeftIdleState(mario);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.GetSetMarioState = new NormalLeftCrouchingState(mario);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.GetSetMarioState = new NormalLeftJumpingState(mario);
        }

        public void Flower()
        {
            mario.GetSetMarioState = new FireLeftRunningState(mario);
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
            mario.GetSetMarioState = new SmallLeftRunningState(mario);
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
            mario.Right();
        }
    }
}
