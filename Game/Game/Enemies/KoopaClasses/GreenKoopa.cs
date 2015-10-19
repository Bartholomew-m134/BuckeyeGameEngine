using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Enemies.KoopaClasses.KoopaStates;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;

namespace Game.Enemies.KoopaClasses
{
    public class GreenKoopa : IEnemy
    {
        public IKoopaState state;
        private ISprite sprite;
        private Game1 myGame;
        private Vector2 location;
        private bool canDealDamage = true;
        private int inShellTimer = 0;

        public GreenKoopa(Game1 game)
        {
            myGame = game;
            state = new GreenKoopaWalkingLeftState(this);
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
            if (state is GreenKoopaHidingInShellState || state is GreenKoopaEmergingFromShellState)
            {
                inShellTimer++;
            }
            if (inShellTimer == 100 && state is GreenKoopaHidingInShellState)
            {
                state.KoopaEmergingFromShell();
                inShellTimer = 0;
            }
            else if (inShellTimer == 45 && state is GreenKoopaEmergingFromShellState)
            {
                state.KoopaChangeDirection();
                inShellTimer = 0;
            }
            sprite.Update();
        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite GetSetSprite
        {
            get { return sprite; }
            set { sprite = value; }
        }
    }
}
