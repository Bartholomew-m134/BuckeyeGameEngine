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
        public IMarioSprite sprite;
        private Game1 myGame;

        int timer = 10000;
        public StarMario(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.sprite = (IMarioSprite)mario.GetSetSprite;
            this.myGame = game;
        }

        public Vector2 getLocation()
        {
            return mario.VectorCoordinates;
        }

        public void setLocation(Vector2 loc)
        {
            mario.VectorCoordinates = loc;
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
            sprite.StarDraw(myGame.spriteBatch, mario.VectorCoordinates);
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

        public ISprite GetSetSprite
        {
            get { return (ISprite)sprite; }
            set { sprite = (IMarioSprite)value; }
        }

        public IMarioSprite GetMarioSprite
        {
            get { return mario.GetMarioSprite; }
        }

        public IMarioState GetSetMarioState
        {
            get { return mario.GetSetMarioState; }
            set { mario.GetSetMarioState = value; }
        }

        public bool IsBig()
        {
            return mario.GetSetMarioState.IsBig();
        }

        public bool IsStar()
        {
            return true;
        }
    }
}
