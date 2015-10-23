using System;
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
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateFireRightRunningSprite();
        }
        public void Update()
        {
            mario.Sprite.Update();
        }

        public void Left()
        {
            mario.MarioState = new FireRightIdleState(mario);
        }

        public void Right()
        {
            ObjectPhysics physics = mario.Physics;
            Vector2 acceleration = physics.Acceleration;
            acceleration.X = 2;
            physics.Acceleration = acceleration;
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioState = new FireRightCrouchingState(mario);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.MarioState = new FireRightJumpingState(mario);
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
            mario.MarioState = new NormalRightRunningState(mario);
        }

        public void Die()
        {
            mario.MarioState = new DeadMarioState(mario);
        }
        public bool IsBig()
        {
            return true;
        }

        public void ToIdle()
        {
            mario.Left();
        }

        public bool IsJumping()
        {
            return false;
        }
    }
}
