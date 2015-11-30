﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;
using Game.SoundEffects;
using Game.Utilities.Constants;
using Game.ProjectPacMario.PlayerClasses;

namespace Game.Mario.MarioStates
{
    public class SmallRightJumpingState : IMarioState
    {

        private IMario mario;

        public SmallRightJumpingState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightJumpingSprite();
            if (!mario.MarioState.IsJumping())
            {
                Vector2 velocity = this.mario.Physics.Velocity;
                velocity.Y = MarioStateConstants.INITIALJUMPVELOCITY;
                this.mario.Physics.Velocity = velocity;
                SoundEffectManager.SmallMarioJumpEffect();
            }
        }
        public void Update()
        {
            mario.Sprite.Update();
        }

        public void Left()
        {
            Vector2 acceleration = mario.Physics.Acceleration;
            acceleration.X = MarioStateConstants.NEGATIVEJUMPINGXACCELERATION;
            mario.Physics.Acceleration = acceleration;
        }

        public void Right()
        {      
            Vector2 acceleration = mario.Physics.Acceleration;
            acceleration.X = MarioStateConstants.POSITIVEJUMPINGXACCELERATION;
            mario.Physics.Acceleration = acceleration;
        }

        public void Up()
        {
            
        }

        public void Down()
        {
            
        }

        public void Jump()
        {
            
        }

        public void StopJumping()
        {
            if (mario.Physics.Velocity.Y < 0)
            {
                mario.Physics.ResetY();
            }
        }

        public void Flower()
        {
            mario.MarioState = new FireRightJumpingState(mario);
            mario.VectorCoordinates += new Vector2(0, MarioStateConstants.POWERUPOFFSET);
        }

        public void PoleSlide()
        {
            mario.MarioState = new SmallFlagPoleSlidingState(mario);

        }
        public void FlipAroundPole()
        {

        }
        public void Mushroom()
        {
            mario.MarioState = new NormalRightJumpingState(mario);
            mario.VectorCoordinates += new Vector2(0, MarioStateConstants.POWERUPOFFSET);
        }

        public void Star()
        {
            
        }

        public void Damage()
        {
            ScoreManager.ResetScore();
            mario.MarioState = new DeadMarioState(mario);
        }

        public bool IsBigMario()
        {
            return false;
        }

        public bool IsFireMario()
        {
            return false;
        }

        public bool IsRight()
        {
            return true;
        }

        public void ToIdle()
        {
            mario.MarioState = new SmallRightIdleState(mario);
        }

        public bool IsJumping()
        {
            return true;
        }


        public void Run()
        {
            
        }

        public void StopRunning()
        {
            mario.Physics.VelocityMaximum = new Vector2(MarioStateConstants.WALKINGVELOCITYMAX, mario.Physics.VelocityMaximum.Y);
            mario.Physics.VelocityMinimum = new Vector2(MarioStateConstants.WALKINGVELOCITYMIN, mario.Physics.VelocityMinimum.Y); 
        }
    }
}
