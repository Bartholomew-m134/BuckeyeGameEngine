using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.Diagnostics;
using Game.Interfaces;
using Game.Utilities;
using Microsoft.Xna.Framework.Graphics;
using Game.Mario.MarioSprites;
using Game.SpriteFactories;
using Game.Utilities.Constants;

namespace Game.Mario
{
    public class ThrowFireLeftDecorator : IMario
    {
        private IMario mario;
        private Game1 myGame;
        private int timer = IMarioObjectConstants.FIRETHROWTIMER;
        ISprite sprite;

        public ThrowFireLeftDecorator(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.myGame = game;
            WorldManager.SetPlayer(this);
            sprite = MarioSpriteFactory.CreateFireThrowLeft();
        }

        public void Damage()
        {
            mario.Damage();
        }

        public void Update()
        {

            timer--;
            if (timer == 0)
            {
                WorldManager.SetPlayer(this.mario);
            }
            mario.Update();
        }

        public void Draw(ICamera camera)
        {
            Vector2 location = mario.VectorCoordinates;
            sprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
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
            mario.StopRunning();
        }

        public void Flower()
        {
            mario.Flower();
        }

        public void ThrowFireball()
        {
            mario.ThrowFireball();
        }

        public void Mushroom()
        {
            mario.Mushroom();
        }

        public void Star()
        {
            mario.Star();
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
      
        public bool IsBigMario()
        {
            return mario.MarioState.IsBigMario();
        }

        public bool IsFireMario()
        {
            return mario.MarioState.IsFireMario();
        }

        public bool IsStarMario()
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

        public IPhysics Physics
        {
            get { return ((IMario)mario).Physics; }
        }

        public bool IsHurt()
        {
            return false;
        }


        public bool IsPressingDown()
        {
            return mario.IsPressingDown();
        }

        public bool IsDead
        {
            get { return mario.IsDead; }
            set { mario.IsDead = value; }
        }
    }
}