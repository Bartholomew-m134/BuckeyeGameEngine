using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Enemies.GreenKoopaClasses.GreenKoopaStates;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Enemies.GreenKoopaClasses
{
    public class GreenKoopa : IKoopa
    {
        public IGreenKoopaState state;
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
        public void Draw()
        {
            greenKoopaSprite.Draw(myGame.spriteBatch, greenKoopaVector);
        }

        public void Update()
        {
            greenKoopaSprite.Update();
        }
    }
}
