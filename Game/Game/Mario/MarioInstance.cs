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
    }
}
