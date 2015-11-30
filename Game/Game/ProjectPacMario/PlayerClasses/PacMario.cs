﻿using Game.Interfaces;
using Game.Mario;
using Game.Mario.MarioStates;
using Game.ProjectPacMario.Utilities;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectPacMario.PlayerClasses
{
    public class PacMario : IMario
    {
        private IMarioState state;
        private IMarioSprite sprite;
        private Vector2 location;
        private Game1 myGame;
        private IPhysics physics;
        private bool isPressingDown;
        private bool isDead;

        public PacMario(Game1 game)
        {
            state = new SmallRightIdleState(this);
            myGame = game;
            physics = new PacMarioGamePhysics();
            isPressingDown = false;
            isDead = false;
        }
        public void Update()
        {
            location = physics.Update(location);
            state.Update();
        }
        public void Draw(ICamera camera)
        {
            sprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }
        public void Left()
        {
            state.Left();
        }
        public void Right()
        {
            state.Right();
        }
        public void Up()
        {
            state.Up();
            this.isPressingDown = false;
        }
        public void Down()
        {
            state.Down();
            this.isPressingDown = true;
        }
        public void Jump()
        {
            state.Jump();
        }
        public void StopJumping()
        {
            state.StopJumping();
        }
        public void Run()
        {
            state.Run();
        }
        public void StopRunning()
        {
            state.StopRunning();
        }
        public void Flower()
        {

        }

        public void ThrowFireball()
        {
           
        }
        public void Mushroom()
        {

        }
        public void Star()
        {
            new StarMarioDecorator(this, myGame);
        }
        public void PoleSlide()
        {

        }
        public void Damage()
        {
            state.Damage();
        }
        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }
        public ISprite Sprite
        {
            get { return (ISprite)sprite; }
            set { sprite = (IMarioSprite)value; }
        }

        public IMarioState MarioState
        {
            get { return state; }
            set { state = value; }
        }

        public bool IsBigMario()
        {
            return state.IsBigMario();
        }

        public bool IsFireMario()
        {
            return state.IsFireMario();
        }

        public bool IsStarMario()
        {
            return false;
        }

        public bool IsJumping()
        {
            return state.IsJumping();
        }

        public void ToIdle()
        {
            state.ToIdle();
        }

        public IPhysics Physics
        {
            get { return physics; }
        }

        public FireBallSpawner FireBallFactory
        {
            get { return null; }
        }

        public bool IsHurt()
        {
            return false;
        }


        public bool IsPressingDown()
        {
            return isPressingDown;
        }


        public bool IsDead
        {
            get { return isDead; }
            set { isDead = value; }
        }
    }
}
