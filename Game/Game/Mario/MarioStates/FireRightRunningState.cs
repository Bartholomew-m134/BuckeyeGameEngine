﻿using System;
using System.Collections.Generic;
using System.Linq;
using Game.Mario;
using System.Text;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;

namespace Game.Mario.MarioStates
{
    public class FireRightRunningState : IMarioState
    {

        private IMario mario;

        public FireRightRunningState(IMario mario)
        {
            this.mario = mario;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateFireRightRunningSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            mario.GetSetMarioState = new FireRightIdleState(mario);
        }

        public void Right()
        {
            ObjectPhysics physics = mario.Physics;
            Vector2 acceleration = physics.GetSetAcceleration;
            acceleration.X = 2;
            physics.GetSetAcceleration = acceleration;
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.GetSetMarioState = new FireRightCrouchingState(mario);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.GetSetMarioState = new FireRightJumpingState(mario);
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
            mario.GetSetMarioState = new NormalRightRunningState(mario);
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
            mario.Left();
        }
    }
}
