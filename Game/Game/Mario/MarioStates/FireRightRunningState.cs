using System;
using System.Collections.Generic;
using System.Linq;
using Game.Mario;
using System.Text;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;

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
            IPhysics physics = mario.Physics;
            Vector2 acceleration = physics.Acceleration;
            acceleration.X = MarioStateConstants.POSITIVERUNNINGXACCELERATION;
            physics.Acceleration = acceleration;
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioState = new FireRightCrouchingState(mario);
            mario.VectorCoordinates += new Vector2(0, MarioStateConstants.SMALLORCROUCHINGOFFSET);
        }

        public void Jump()
        {
           
             mario.MarioState = new FireRightJumpingState(mario);
        }

        public void StopJumping()
        {
        }

        public void Flower()
        {

        }

        public void PoleSlide()
        {
            mario.MarioState = new FireFlagPoleSlidingState(mario);
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
            mario.MarioState = new NormalRightRunningState(mario);
        }

        public bool IsBigMario()
        {
            return true;
        }

        public bool IsFireMario()
        {
            return true;
        }

        public bool IsRight()
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

        public void Run()
        {
            mario.Physics.VelocityMaximum = new Vector2(MarioStateConstants.RUNNINGVELOCITYMAX, mario.Physics.VelocityMaximum.Y);
            mario.Physics.VelocityMinimum = new Vector2(MarioStateConstants.RUNNINGVELOCITYMIN, mario.Physics.VelocityMinimum.Y);

        }

        public void StopRunning()
        {
            mario.Physics.VelocityMaximum = new Vector2(MarioStateConstants.WALKINGVELOCITYMAX, mario.Physics.VelocityMaximum.Y);
            mario.Physics.VelocityMinimum = new Vector2(MarioStateConstants.WALKINGVELOCITYMIN, mario.Physics.VelocityMinimum.Y);
        }
    }
}
