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
            
            Vector2 acceleration = mario.Physics.GetSetAcceleration;
            acceleration.X = -2;
            mario.Physics.GetSetAcceleration = acceleration;
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
