using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Enemies.GoombaClasses.GoombaStates;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;

namespace Game.Enemies.GoombaClasses
{
    public class Goomba : IEnemy
    {
        public IGoombaState state;
        private ISprite sprite;
        private Game1 myGame;
        private Vector2 location;
        private bool canDealDamage = true;
        private ObjectPhysics physics;
        private int deathTimer = 0;

        public Goomba(Game1 game)
        {
            myGame = game;
            state = new GoombaWalkingLeftState(this);
            physics = new ObjectPhysics();
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

        public void Draw(ICamera camera)
        {
            sprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public void Update()
        {
            if (state is GoombaSmashedState && deathTimer == 3)
            {
                location.Y += 2000;
                deathTimer = 0;
                state = new GoombaWalkingLeftState(this);
            }
            else if (state is GoombaSmashedState)
            {
                deathTimer++;
            }

            sprite.Update();
        }

        public Vector2 VectorCoordinates
        {
            get{return location;}
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return sprite; }
            set { sprite = value; }
        }

        public ObjectPhysics Physics
        {
            get { return physics; }
        }
    }
}
