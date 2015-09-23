using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Enemies.GoombaClasses.GoombaStates;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Enemies.GoombaClasses
{
    public class Goomba
    {
        public IGoombaState state;
        public ISprite goombaSprite;
        private Game1 myGame;
        private Vector2 goombaVector;

        public Goomba(Game1 game)
        {
            myGame = game;
            state = new GoombaWalkingLeftState(this, myGame);
            goombaVector.X = 400;
            goombaVector.Y = 200;
        }

        public void SmashedGoomba()
        {
            state.SmashGoomba();
        }

        public void DirectionChangeGoomba()
        {
            state.DirectionChangeGoomba();
        }

        public void FlipGoomba()
        {
            state.FlipGoomba();
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            goombaSprite.Draw(spriteBatch, goombaVector);
        }

        public void Update()
        {
            goombaSprite.Update();
        }
    }
}
