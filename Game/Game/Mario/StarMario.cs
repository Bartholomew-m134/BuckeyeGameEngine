using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.States;
using Microsoft.Xna.Framework;

namespace Game.Mario
{
    class StarMario : IMario
    {
        MarioInstance mario;
        public ISprite sprite;
        private Vector2 location;
        private Game1 myGame;

        int timer = 1000;
        public StarMario(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.sprite = mario.GetSprite;
            this.location = mario.getLocation();
            this.myGame = game;
        }

        void Damage()
        {
            // StarMario does not take damage
        }

        void Update()
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
            sprite.StarDraw(myGame.spriteBatch, location);
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

        public void Die()
        {
            mario.Die();
        }


        public Vector2 VectorCoordinates
        {
            get { return mario.VectorCoordinates; }
            set { mario.VectorCoordinates = value; }
        }

        public ISprite GetSprite
        {
            get { return mario.GetSprite; }
        }

        public bool IsBig()
        {
            return mario.state.IsBig();
        }
    }
}
