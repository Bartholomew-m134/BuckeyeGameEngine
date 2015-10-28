﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Mario.MarioStates;
using Game.Utilities;

namespace Game.Mario
{
    public class MarioInstance : IMario
    {
        private IMarioState state;
        private IMarioSprite sprite;
        private Vector2 location;
        private Game1 myGame;
        private ObjectPhysics physics;

        public MarioInstance(Game1 game)
        {

            state = new SmallRightIdleState(this);
            myGame = game;
            physics = new ObjectPhysics();
  
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
        }


        public void Down()
        {
            state.Down();
        }

        public void Jump()
        {
            if (Physics.Velocity.Y < 2)
             state.Jump();
        }

        public void StopJumping() {
            state.StopJumping();
        }

        public void Flower()
        {
            if (!this.isFire())
            {
                new FireMario(this, myGame);
            }
        }

        public void Fire()
        {
            
        }


        public void Mushroom()
        {
            if(!this.IsBig())
            {
                new GrowMario(this, myGame);
           }
        }

        public void Star()
        {
            
            new StarMario(this, myGame);
        }

        public void PoleSlide()
        {
            Physics.ResetX();
            Physics.ResetY();
            state.PoleSlide();
        }

        public void Damage()
        {
            if (this.IsBig())
            {
                state.Damage();
                new HurtMario(this, myGame);
            }
            else
            {
                state.Damage();
            }
        }


        public void Die()
        {
            state.Die();
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

        public bool Transition()
        {
            return false;
        }

        public bool IsBig()
        {
            return state.IsBig();
        }

        public bool isFire()
        {
            return state.IsFire();
        }

        public bool IsStar()
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

        public ObjectPhysics Physics
        {
            get { return physics; }
        }
    }
}
