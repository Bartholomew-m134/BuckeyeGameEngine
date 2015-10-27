﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Enemies.KoopaClasses.KoopaStates;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;

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
        private ObjectPhysics physics;
        private bool isFlipped = false;
        private bool isHit = false;

        public GreenKoopa(Game1 game)
        {
            myGame = game;
            state = new GreenKoopaWalkingLeftState(this);
            physics = new ObjectPhysics();
        }

        public void Hit()
        {
            state.KoopaHidingInShell();
        }

        public void ShiftDirection()
        {
            state.KoopaChangeDirection();
        }

        public void Flipped()
        {
            physics.Velocity = new Vector2(0, -5);
            physics.Acceleration = new Vector2(0, 1);
            state.KoopaShellFlipped();
        }

        public bool IsFlipped
        {
            get { return isFlipped; }
            set { isFlipped = value; }
        }

        public bool IsHit
        {
            get { return isHit; }
            set { isHit = value; }
        }

        public bool CanDealDamage
        {
            get { return canDealDamage; }
            set { canDealDamage = value; }
        }

        public void Draw(ICamera camera)
        {
            sprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
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
                canDealDamage = true;
                inShellTimer = 0;
            }
            if (!isHit)
            {
                location = physics.Update(location);
            }
            sprite.Update();
        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return sprite; }
            set { sprite = value; }
        }

        public ObjectPhysics Physics
        {
            get {return physics;}
        }
    }
}
