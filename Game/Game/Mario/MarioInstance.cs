using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Mario.MarioStates;

namespace Game.Mario
{
    public class MarioInstance : IMario
    {
        private IMarioState state;
        private IMarioSprite sprite;
        private Vector2 location;
        private Game1 myGame;
        

        public MarioInstance(Game1 game)
        {

            state = new SmallRightIdleState(this);
            myGame = game;
  
        }

        public void Update()
        {
            state.Update();
        }

        public void Draw() 
        {
            sprite.Draw(myGame.spriteBatch, location);
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


        public void Land()
        {
            state.Land();
        }


        public void Jump()
        {
            state.Jump();
        }


        public void Flower()
        {
            state.Flower();
        }


        public void Mushroom()
        {
            state.Mushroom();
        }

        public void Star()
        {
            //state.Star();
            new StarMario(this, myGame);
        }


        public void Damage()
        {
            state.Damage();
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

        public ISprite GetSetSprite
        {
            get { return (ISprite)sprite; }
            set { sprite = (IMarioSprite)value; }
        }

        public IMarioState GetSetMarioState
        {
            get { return state; }
            set { state = value; }
        }


        public bool IsBig()
        {
            return state.IsBig();
        }

        public bool IsStar()
        {
            return false;
        }

        public void ToIdle()
        {
            state.ToIdle();
        }
    }
}
