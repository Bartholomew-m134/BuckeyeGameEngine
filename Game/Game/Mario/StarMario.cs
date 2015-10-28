using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.Diagnostics;
using Game.Interfaces;
using Game.Utilities;

namespace Game.Mario
{
    public class StarMario : IMario
    {
        private IMario mario;
        private Game1 myGame;
        private int timer = 200;

        public StarMario(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.myGame = game;
            WorldManager.SetMario(this);
        }

        public void Damage()
        {
        }

        public void Update()
        {
            timer--;
            if (timer == 0)
            {
                WorldManager.SetMario(this.mario);
            }
            mario.Update();
        }

        public void Draw(ICamera camera)
        {
            ((IMarioSprite)mario.Sprite).StarDraw(myGame.spriteBatch, camera.GetAdjustedPosition(mario.VectorCoordinates));
        }

        public void Left()
        {
            mario.Left();
        }

        public void Right()
        {
            mario.Right();
        }

        public void Up()
        {
            mario.Up();
        }

        public void Down()
        {
            mario.Down();
        }

        public void Jump()
        {
            mario.Jump();
        }

        public void StopJumping()
        {
            mario.StopJumping();
        }

        public void Run() 
        {
            mario.Run();
        }

        public void StopRunning() 
        {
            mario.StopJumping();
        }

        public void Flower()
        {
            mario.Flower();
        }

        public void Fire()
        {
            mario.Fire();
        }

        public void Mushroom()
        {
            mario.Mushroom();
        }

        public void Star()
        {
            timer = 1000;
        }

        public void PoleSlide()
        {
            mario.PoleSlide();
        }

        public Vector2 VectorCoordinates
        {
            get { return mario.VectorCoordinates; }
            set { mario.VectorCoordinates = value; }
        }

        public ISprite Sprite
        {
            get { return mario.Sprite; }
            set { mario.Sprite = (IMarioSprite)value; }
        }

        public IMarioState MarioState
        {
            get { return mario.MarioState; }
            set { mario.MarioState = value; }
        }
        public bool Transition()
        {
            return mario.Transition();
        }
        public bool IsBig()
        {
            return mario.MarioState.IsBig();
        }

        public bool isFire()
        {
            return mario.MarioState.IsFire();
        }

        public bool IsStar()
        {
            return true;
        }

        public bool IsJumping()
        {
            return mario.MarioState.IsJumping();
        }

        public void ToIdle()
        {
            mario.ToIdle();
        }

        public ObjectPhysics Physics
        {
            get { return ((MarioInstance)mario).Physics; }
        }
    }
}
