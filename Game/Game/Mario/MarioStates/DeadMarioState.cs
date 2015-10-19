﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Interfaces;


namespace Game.Mario.MarioStates
{
    public class DeadMarioState : IMarioState
    {

        private IMario mario;

        public DeadMarioState(IMario mario)
        {
            this.mario = mario;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateDeadSprite();
        }

        public void Update() {
            mario.GetSetSprite.Update();
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

        public void Flower()
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
            return false;
        }

        public void ToIdle()
        {

        }
    }
}