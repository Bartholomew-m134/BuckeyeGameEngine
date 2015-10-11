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
        public ISprite sprite;
        private Game1 myGame;
        private Vector2 location;
        private bool canDealDamage = true;

        public Goomba(Game1 game)
        {
            myGame = game;
            state = new GoombaWalkingLeftState(this);
        }

        public void IsHit()
        {
            state.SmashGoomba();
        }

        public void ShiftDirection()
        {
            state.DirectionChangeGoomba();
        }

        public void Flipped()
        {
            state.FlipGoomba();
        }

        public bool CanDealDamage
        {
            get { return canDealDamage; }
            set { canDealDamage = value; }
        }

        public void Draw()
        {
            sprite.Draw(myGame.spriteBatch, location);
        }

        public void Update()
        {
            sprite.Update();
        }

        public Vector2 VectorCoordinates
        {
            get{return location;}
            set { location = value; }
        }

        public ISprite GetSetSprite
        {
            get { return sprite; }
            set { sprite = value; }
        }
    }
}
