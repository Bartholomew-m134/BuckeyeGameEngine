using Game.Interfaces;
using Game.Utilities;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Mario.MarioStates
{
        public class NormalFlagPoleSlidingState : IMarioState
        {

            private IMario mario;

            public NormalFlagPoleSlidingState(IMario mario)
            {
                this.mario = mario;
                mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateNormalFlagPoleSlidingSprite();
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
                mario.MarioState = new NormalRightIdleState(mario);
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
            public void PoleSlide()
            {
                
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
