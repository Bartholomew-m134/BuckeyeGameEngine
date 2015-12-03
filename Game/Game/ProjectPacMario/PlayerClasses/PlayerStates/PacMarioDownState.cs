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
    public class PacMarioDownState : IMarioState
    {
        private IMario mario;

        public PacMarioDownState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.PacMarioSpriteFactory.CreateDownPacMarioSprite();
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
            mario.MarioState = new PacMarioRightState(mario);
        }

        public void Up()
        {
            mario.MarioState = new PacMarioUpState(mario);
        }

        public void Down()
        {
            Vector2 acceleration = mario.Physics.Acceleration;
            acceleration.Y = MarioStateConstants.POSITIVERUNNINGXACCELERATION;
            mario.Physics.Acceleration = acceleration;
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
            mario.Physics.ResetY();
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
