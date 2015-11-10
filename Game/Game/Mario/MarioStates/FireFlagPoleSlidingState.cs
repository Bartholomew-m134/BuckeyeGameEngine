using Game.Interfaces;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Mario.MarioStates
{
    class FireFlagPoleSlidingState : IMarioState
    {
         private IMario mario;

            public FireFlagPoleSlidingState(IMario mario)
            {
                this.mario = mario;
                mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateFireFlagPoleSlidingSprite();
            }
            public void Update()
            {
                mario.Sprite.Update();
            }

            public void Left()
            {
               
            }

            public void Right()
            {
                mario.MarioState = new FireRightRunningState(mario);
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

            public void PoleSlide()
            {
               
            }

            public void FlipAroundPole()
            {
                mario.VectorCoordinates = new Vector2((int)mario.VectorCoordinates.X + MarioSpriteConstants.FIREFLAGMARIOWIDTHHEIGHT.X, (int)mario.VectorCoordinates.Y);
                mario.MarioState = new FireFlagPoleFlippedState(mario);
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
                return true;
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

            }

            public void StopRunning()
            {
                mario.Physics.VelocityMaximum = new Vector2(6, mario.Physics.VelocityMaximum.Y);
                mario.Physics.VelocityMinimum = new Vector2(-6, mario.Physics.VelocityMinimum.Y);
            }
    }
}
