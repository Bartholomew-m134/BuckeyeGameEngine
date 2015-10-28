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

namespace Game.Mario
{
    public class FireThrowLeftMario : IMario
    {
        private IMario mario;
        private Game1 myGame;
        private int timer = 5;
        ISprite sprite;

        public FireThrowLeftMario(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.myGame = game;
            WorldManager.SetMario(this);
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
                WorldManager.SetMario(this.mario);
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
        public bool isTransitioning()
        {
            return mario.isTransitioning();
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

        public bool isHurt()
        {
            return false;
        }
    }
}