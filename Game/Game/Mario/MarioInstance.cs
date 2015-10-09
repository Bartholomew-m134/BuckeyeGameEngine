using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.States;
using Microsoft.Xna.Framework;

namespace Game.Mario
{
    public class MarioInstance : IMario
    {
        public IMarioState state;
        public ISprite sprite;
        private Vector2 location;
        private Game1 myGame;

        public MarioInstance(Game1 game)
        {
            state = new SmallRightIdleState(this, game);
            location = new Vector2(358, 316);
            myGame = game;
        }

        public Vector2 getLocation()
        {
            return this.location;
        }

        public void setLocation(Vector2 loc)
        {
            this.location = loc;
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

        //public void Star()
        //{
        //    state.Star();
        //}


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

        public ISprite GetSprite
        {
            get { return sprite; }
        }

        public bool IsBig()
        {
            return state.IsBig();
        }
    }
}
