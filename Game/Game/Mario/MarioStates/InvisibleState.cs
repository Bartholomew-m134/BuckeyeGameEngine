using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;

namespace Game.Mario.MarioStates
{
    public class InvisibleState : IMarioState
    {
        private IMario mario;

        public InvisibleState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateInvisibleSprite();
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

        public void PoleSlide()
        {
            
        }
        public void FlipAroundPole()
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

        public bool IsBigMario()
        {
            return false;
        }

        public bool IsFireMario()
        {
            return false;
        }

        public bool IsRight()
        {
            return true;
        }

        public void ToIdle()
        {

        }

        public bool IsJumping()
        {
            return false;
        }

        public void Run()
        {

        }

        public void StopRunning()
        {

        }
    }
}
