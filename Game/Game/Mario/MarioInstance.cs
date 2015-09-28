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
            state = new SmallRightIdle(this, game);
            location = new Vector2(358, 316);
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

        public void left()
        {
            state.left();
        }


        public void right()
        {
            state.right();
        }


        public void up()
        {
            state.up();
        }


        public void down()
        {
            state.down();
        }


        public void land()
        {
            state.land();
        }


        public void jump()
        {
            state.jump();
        }


        public void flower()
        {
            state.flower();
        }


        public void mushroom()
        {
            state.mushroom();
        }


        public void damage()
        {
            state.damage();
        }


        public void die()
        {
            state.die();
        }
    }
}
