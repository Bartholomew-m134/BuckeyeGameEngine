using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Mario.MarioStates
{
    class SmallFlagPoleSlidingState : IMarioState
    {
         private IMario mario;

            public SmallFlagPoleSlidingState(IMario mario)
            {
                this.mario = mario;
                mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateSmallFlagPoleSlidingSprite();
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


            public void Jump()
            {

            }

            public void StopJumping()
            {
            }

            public void Flower()
            {

            }

            public void Fire()
            {

            }
            public void PoleSlide()
            {
                mario.MarioState = new SmallFlagPoleSlidingState(mario);
            }

            public void Mushroom()
            {
            }

            public void Star()
            {
                
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

            public bool IsFire()
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
