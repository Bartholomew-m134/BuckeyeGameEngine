using Game.Interfaces;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Mario.MarioStates
{
    class SmallFlagPoleSlidingState : IMarioState
    {
         private IMario mario;

            public SmallFlagPoleSlidingState(IMario mario)
            {
                this.mario = mario;
                mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateSmallFlagPoleSlidingSprite();
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
                mario.MarioState = new SmallRightRunningState(mario);
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

            public void PoleSlide()
            {
            }
            public void FlipAroundPole()
            {
                mario.VectorCoordinates = new Vector2((int)mario.VectorCoordinates.X + MarioSpriteConstants.SMALLFLAGMARIODIMENSIONS.X,(int)mario.VectorCoordinates.Y);
                mario.MarioState = new SmallFlagPoleFlippedState(mario);
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
                return false;
            }

            public bool IsRight()
            {
                return true;
            }

            public void ToIdle()
            {

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
                mario.Physics.VelocityMaximum = new Vector2(MarioStateConstants.WALKINGVELOCITYMAX, mario.Physics.VelocityMaximum.Y);
                mario.Physics.VelocityMinimum = new Vector2(MarioStateConstants.WALKINGVELOCITYMIN, mario.Physics.VelocityMinimum.Y);
            }
    }
}
