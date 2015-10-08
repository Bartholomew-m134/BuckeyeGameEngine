using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Enemies.GoombaClasses.GoombaStates;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Enemies.GoombaClasses
{
    public class Goomba : IEnemy
    {
        public IGoombaState state;
        public ISprite goombaSprite;
        private Game1 myGame;
        private Vector2 goombaVector;

        public Goomba(Game1 game)
        {
            myGame = game;
            state = new GoombaWalkingLeftState(this);
            goombaVector.X = 500;
            goombaVector.Y = 100;
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

        public void Draw()
        {
            goombaSprite.Draw(myGame.spriteBatch, goombaVector);
        }

        public void Update()
        {
            goombaSprite.Update();
        }

        Vector2 VectorCoordinates
        {
            get{return goombaVector;}
            set { goombaVector = value; }
        }

        ISprite GetSprite
        {
            get { return goombaSprite; }
        }
    }
}
