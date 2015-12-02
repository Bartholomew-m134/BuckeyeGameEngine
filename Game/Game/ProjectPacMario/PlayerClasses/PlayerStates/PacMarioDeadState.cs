using Game.Interfaces;
using Game.Mario;
using Game.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectPacMario.PlayerClasses.PlayerStates
{
    public class PacMarioDeadState : IMarioState
    {
        private IMario mario;

        public PacMarioDeadState(IMario mario)
        {
            this.mario = mario;
            BackgroundThemeManager.PlayPacMarioDeathTheme();
            mario.Sprite = SpriteFactories.PacMarioSpriteFactory.CreateDeadPacMarioSprite();
            mario.Physics.ResetPhysics();
        }
        public void Update()
        {
            mario.Sprite.Update();
        }

        public void Left()
        {
        }
        public void PoleSlide()
        {
            
        }
        public void FlipAroundPole()
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
