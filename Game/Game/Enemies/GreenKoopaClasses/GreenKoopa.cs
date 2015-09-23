using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Enemies.GreenKoopaClasses.GreenKoopaStates;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Enemies.GreenKoopaClasses
{
    public class GreenKoopa
    {
        public IGreenKoopaState state;
        public ISprite greenKoopaSprite;
        private Game1 myGame;
        private Vector2 greenKoopaVector;

        public GreenKoopa(Game1 game)
        {
            myGame = game;
            state = new GreenKoopaWalkingLeftState(this, myGame);
            greenKoopaVector.X = 400;
            greenKoopaVector.Y = 200;
        }

        public void GreenKoopaEmergingFromShell()
        {
            state.GreenKoopaEmergingFromShell();
        }

        public void GreenKoopaShellFlipped()
        {
            state.GreenKoopaShellFlipped();
        }

        public void GreenKoopaHidingInShell()
        {
            state.GreenKoopaHidingInShell();
        }

        public void GreenKoopaChangeDirection()
        {
            state.GreenKoopaChangeDirection();
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            greenKoopaSprite.Draw(spriteBatch, greenKoopaVector);
        }

        public void Update()
        {
            greenKoopaSprite.Update();
        }
    }
}
