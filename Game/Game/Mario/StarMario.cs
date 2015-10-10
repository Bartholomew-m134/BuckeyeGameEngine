using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.States;
using Microsoft.Xna.Framework;

namespace Game.Mario
{
    public class StarMario : IMario
    {
        public IMario mario;
        public ISprite sprite;
        public IMarioSprite mariosprite;
        private Vector2 location;
        private Game1 myGame;

        int timer = 10000;
        public StarMario(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.sprite = mario.GetSprite;
            this.location = mario.VectorCoordinates;
            this.myGame = game;
        }

        public Vector2 getLocation()
        {
            return this.location;
        }

        public void setLocation(Vector2 loc)
        {
            this.location = loc;
        }

        public void Damage()
        {
        }

        public void Update()
        {
            timer--;
            if (timer == 0)
            {
                RemoveStar();
            }

            mario.Update();
        }

        void RemoveStar()
        {
            WorldManager.SetMario(mario);
        }

        public void Draw()
        {
            mariosprite.StarDraw(myGame.spriteBatch, location);
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

        public void Land()
        {
            mario.Land();
        }

        public void Jump()
        {
            mario.Jump();
        }

        public void Flower()
        {
            mario.Flower();
        }

        public void Mushroom()
        {
            mario.Mushroom();
        }

        public void Star()
        {
            mario = new StarMario(mario, myGame);
        }

        public void Die()
        {
        }


        public Vector2 VectorCoordinates
        {
            get { return mario.VectorCoordinates; }
            set { mario.VectorCoordinates = value; }
        }

        public ISprite GetSprite
        {
            get { return mario.GetSprite; }
            set { sprite = value; }
        }

        public IMarioSprite GetMarioSprite
        {
            get { return mario.GetMarioSprite; }
        }

        public IMarioState MarioStateProperty
        {
            get { return mario.MarioStateProperty; }
            set { mario.MarioStateProperty = value; }
        }

        public bool IsBig()
        {
            return mario.MarioStateProperty.IsBig();
        }
    }
}
