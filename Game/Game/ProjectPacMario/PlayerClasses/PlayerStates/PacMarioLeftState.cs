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
    public class PacMarioLeftState : IMarioState
    {
        private IMario mario;

        public PacMarioLeftState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.PacMarioSpriteFactory.CreateLeftPacMarioSprite();
        }
        public void Update()
        {
            mario.Sprite.Update();
        }

        public void Left()
        {
            Vector2 acceleration = mario.Physics.Acceleration;
            acceleration.X = MarioStateConstants.NEGATIVERUNNINGXACCELERATION;
            mario.Physics.Acceleration = acceleration;
        }
        public void PoleSlide()
        {
            
        }
        public void FlipAroundPole()
        {

        }

        public void Right()
        {
            mario.MarioState = new PacMarioRightState(mario);
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
