using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Mario.MarioStates
{
    class FireFlagPoleSlidingState : IMarioState
    {
         private IMario mario;

            public FireFlagPoleSlidingState(IMario mario)
            {
                this.mario = mario;
                mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateFireFlagPoleSlidingSprite();
            }
            public void Update()
            {
                mario.Sprite.Update();
            }

            public void Left()
            {
               
            }

            public void Right()
            {

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

            }

            public void StopJumping()
            {
            }

            public void Flower()
            {

            }

            public void Mushroom()
            {
            }

            public void Star()
            {
                
            }

            public void PoleSlide()
            {
                mario.MarioState = new FireFlagPoleSlidingState(mario);
            }

            public void Damage()
            {
                
            }

            public void Die()
            {
                
            }
            public bool IsBig()
            {
                return true;
            }

            public void ToIdle()
            {
                mario.Right();
            }

            public bool IsJumping()
            {
                return false;
            }
    }
}
