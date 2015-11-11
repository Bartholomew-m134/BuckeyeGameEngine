using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Interfaces;
using Game.Music;
using Microsoft.Xna.Framework;


namespace Game.Mario.MarioStates
{
    public class DeadMarioState : IMarioState
    {

        private IMario mario;

        public DeadMarioState(IMario mario)
        {
            this.mario = mario;
            BackgroundThemeManager.PlayDeathTheme();
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateDeadSprite();
            mario.Physics.ResetPhysics();
            mario.Physics.Velocity = new Vector2(0, -9);
        }

        public void Update() {
            mario.Sprite.Update();
        }

        public void Left()
        {

        }

        public void Right()
        {

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
