using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Interfaces;
using Microsoft.Xna.Framework;


namespace Game.Mario.MarioStates
{
    public class DeadMarioState : IMarioState
    {

        private IMario mario;

        public DeadMarioState(IMario mario)
        {
            this.mario = mario;
            mario.Sprite = SpriteFactories.MarioSpriteFactory.CreateDeadSprite();
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

        public void Fire()
        {

        }
        public void PoleSlide()
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

        public bool IsBig()
        {
            return false;
        }

        public bool IsFire()
        {
            return false;
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
            mario.Physics.VelocityMaximum = new Vector2(6, mario.Physics.VelocityMaximum.Y);
            mario.Physics.VelocityMinimum = new Vector2(-6, mario.Physics.VelocityMinimum.Y);
        }
    }
}
