using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;

namespace Game.Mario.MarioStates
{
    public class SmallLeftRunningState : IMarioState
    {

        private IMario mario;

        public SmallLeftRunningState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateSmallLeftRunningSprite();
        }
        public void Update()
        {
            mario.Sprite.Update();
        }

        public void Left()
        {
            
            Vector2 acceleration = mario.Physics.Acceleration;
            acceleration.X = -2;
            mario.Physics.Acceleration = acceleration;
        }

        public void Right()
        {
            mario.MarioState = new SmallLeftIdleState(mario);
        }

        public void Up()
        {

        }

        public void Down()
        {
            
        }

        public void Jump()
        {      
            mario.MarioState = new SmallLeftJumpingState(mario);
        }

        public void StopJumping()
        {
        }

        public void Flower()
        {
            mario.MarioState = new FireLeftRunningState(mario);
            mario.VectorCoordinates += new Vector2(0, -16);
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
            mario.MarioState = new NormalLeftRunningState(mario);
            mario.VectorCoordinates += new Vector2(0, -16);
        }

        public void Star()
        {
        }

        public void Damage()
        {
            mario.MarioState = new DeadMarioState(mario);
        }

        public bool IsBig()
        {
            return false;
        }

        public void ToIdle()
        {
            mario.Right();
        }

        public bool IsJumping()
        {
            return false;
        }

        public void Run()
        {
            mario.Physics.VelocityMaximum = new Vector2(10, mario.Physics.VelocityMaximum.Y);
            mario.Physics.VelocityMinimum = new Vector2(-10, mario.Physics.VelocityMinimum.Y);

        }

        public void StopRunning()
        {
            mario.Physics.VelocityMaximum = new Vector2(6, mario.Physics.VelocityMaximum.Y);
            mario.Physics.VelocityMinimum = new Vector2(-6, mario.Physics.VelocityMinimum.Y);
        }
    }
}
