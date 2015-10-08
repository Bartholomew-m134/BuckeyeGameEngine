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
        public ISprite greenKoopaSprite;
        private Game1 myGame;
        private Vector2 greenKoopaVector;

        public GreenKoopa(Game1 game)
        {
            myGame = game;
            state = new GreenKoopaWalkingLeftState(this);
            greenKoopaVector.X = 600;
            greenKoopaVector.Y = 100;
        }

        public void GreenKoopaEmergingFromShell()
        {
            state.KoopaEmergingFromShell();
        }

        public void GreenKoopaShellFlipped()
        {
            state.KoopaShellFlipped();
        }

        public void GreenKoopaHidingInShell()
        {
            state.KoopaHidingInShell();
        }

        public void GreenKoopaChangeDirection()
        {
            state.KoopaChangeDirection();
        }
        public void Draw()
        {
            greenKoopaSprite.Draw(myGame.spriteBatch, greenKoopaVector);
        }

        public void Update()
        {
            greenKoopaSprite.Update();
        }

        Vector2 VectorCoordinates
        {
            get { return greenKoopaVector; }
            set { greenKoopaVector = value; }
        }

        ISprite GetSprite
        {
            get { return greenKoopaSprite; }
        }
    }
}
