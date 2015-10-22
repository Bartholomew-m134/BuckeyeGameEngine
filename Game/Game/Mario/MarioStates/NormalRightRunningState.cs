﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;

namespace Game.Mario.MarioStates
{
    public class NormalRightRunningState : IMarioState
    {

        private IMario mario;

        public NormalRightRunningState(IMario mario)
        {
            this.mario = mario;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightRunningSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            mario.GetSetMarioState = new NormalRightIdleState(mario);
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
            mario.GetSetMarioState = new NormalRightCrouchingState(mario);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.GetSetMarioState = new NormalRightJumpingState(mario);
        }

        public void Flower()
        {
            mario.GetSetMarioState = new FireRightRunningState(mario);
        }

        public void Mushroom()
        {

        }

        public void Star()
        {
            //mario = new StarMario(mario, game);
        }

        public void Damage()
        {
            mario.GetSetMarioState = new SmallRightRunningState(mario);
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
