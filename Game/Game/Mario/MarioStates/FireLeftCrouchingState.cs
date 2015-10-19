﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;

namespace Game.Mario.MarioStates
{
    public class FireLeftCrouchingState : IMarioState
    {

        private IMario mario;

        public FireLeftCrouchingState(IMario mario)
        {
            this.mario = mario;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateFireLeftCrouchingSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            mario.GetSetMarioState = new FireLeftRunningState(mario);
        }

        public void Right()
        {
            mario.GetSetMarioState = new FireRightRunningState(mario);
        }

        public void Up()
        {
            mario.GetSetMarioState = new FireLeftIdleState(mario);
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
            mario.GetSetMarioState = new FireLeftIdleState(mario);
        }

        public void Flower()
        {

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
            mario.GetSetMarioState = new NormalLeftIdleState(mario);
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