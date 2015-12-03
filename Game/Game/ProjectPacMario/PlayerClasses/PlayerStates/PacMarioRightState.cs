using Game.Interfaces;
using Game.Mario;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectPacMario.PlayerClasses.PlayerStates
{
    public class PacMarioRightState : IMarioState
    {
        private IMario mario;

        public PacMarioRightState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.PacMarioSpriteFactory.CreateRightPacMarioSprite();
        }
        public void Update()
        {
            mario.Sprite.Update();
        }

        public void Left()
        {
            mario.MarioState = new PacMarioLeftState(mario);
        }
        public void PoleSlide()
        {
            
        }
        public void FlipAroundPole()
        {

        }

        public void Right()
        {
            Vector2 acceleration = mario.Physics.Acceleration;
            acceleration.X = MarioStateConstants.POSITIVERUNNINGXACCELERATION;
            mario.Physics.Acceleration = acceleration;
        }

        public void Up()
        {
            mario.MarioState = new PacMarioUpState(mario);
        }

        public void Down()
        {
            mario.MarioState = new PacMarioDownState(mario);
        }

        public void Jump()
        {
            Vector2 acceleration = mario.Physics.Acceleration;
            acceleration.Y = MarioStateConstants.NEGATIVERUNNINGXACCELERATION;
            mario.Physics.Acceleration = acceleration;
        }

        public void StopJumping()
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
            mario.MarioState = new PacMarioDeadState(mario);
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
            return false;
        }
        public void ToIdle()
        {
            mario.Physics.ResetX();
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
