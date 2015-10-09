using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Enemies.KoopaClasses.KoopaStates;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Enemies.KoopaClasses
{
    public class GreenKoopa : IEnemy
    {
        public IKoopaState state;
        public ISprite sprite;
        private Game1 myGame;
        private Vector2 location;
        private bool canDealDamage = true;

        public GreenKoopa(Game1 game)
        {
            myGame = game;
            state = new GreenKoopaWalkingLeftState(this);
            location.X = 600;
            location.Y = 100;
        }

        public void IsHit()
        {
            state.KoopaHidingInShell();
        }

        public void ShiftDirection()
        {
            state.KoopaChangeDirection();
        }

        public void Flipped()
        {
            state.KoopaShellFlipped();
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
            get { return location; }
            set { location = value; }
        }

        public ISprite GetSprite
        {
            get { return sprite; }
        }
    }
}
