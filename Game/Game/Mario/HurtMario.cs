﻿using Game.Interfaces;
using Game.Utilities;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Mario
{
    public class HurtMario : IMario
    {
         private IMario mario;
        private Game1 myGame;
        private int frame;

        public HurtMario(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.myGame = game;
            WorldManager.SetMario(this);
            frame = 0;
        }

        public void Damage()
        {
        }

        public void Update()
        {
            if (frame == 18)
            {
                WorldManager.SetMario(this.mario);
            }
            mario.Update();

            frame++;
            
        }

        public void Draw(ICamera camera)
        {

            if (frame % 2 == 0 && frame % 4 == 0)
            {
                mario.Draw(camera);
            }
            else if (frame % 2 == 1 && frame % 4 != 0)
            {
                
            }
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
            mario.Star();
        }

        public void Die()
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
            return mario.IsStar();
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



        public void Run()
        {
            mario.Run();
        }

        public void StopRunning()
        {
            mario.StopRunning();
        }


        public bool isHurt()
        {
            return true;
        }
    }
}