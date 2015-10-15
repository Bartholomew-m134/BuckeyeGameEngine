using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    public class NormalRightCrouchingState : IMarioState
    {

        private IMario mario;

        public NormalRightCrouchingState(IMario mario)
        {
            this.mario = mario;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightCrouchingSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            mario.GetSetMarioState = new NormalLeftRunningState(mario);
        }

        public void Right()
        {
            mario.GetSetMarioState = new NormalRightRunningState(mario);
        }

        public void Up()
        {
            
        }

        public void Down()
        {
            Vector2 loc = mario.VectorCoordinates;
            loc.Y += 4;
            mario.VectorCoordinates = loc;
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.GetSetMarioState = new NormalRightIdleState(mario);
        }

        public void Flower()
        {
            mario.GetSetMarioState = new FireRightCrouchingState(mario);
        }

        public void Mushroom()
        {

        }

        public void Star()
        {
            //mario = new StarMario((MarioInstance)mario);
        }

        public void Damage()
        {
            mario.GetSetMarioState = new SmallLeftIdleState(mario);
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
