using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Enemies.GoombaClasses.GoombaStates;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;

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
        private bool isFlipped = false;
        private bool isHit = false;

        public Goomba(Game1 game)
        {
            myGame = game;
            physics = new ObjectPhysics();
            state = new GoombaWalkingLeftState(this);
        }

        public void Hit()
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
            if (state is GoombaSmashedState && deathTimer == IEnemyObjectConstants.STOMPEDGOOMBADELAYTIME)
            {
                location.Y += IEnemyObjectConstants.VANISH;
                deathTimer = 0;
                state = new GoombaWalkingLeftState(this);
            }
            else if (state is GoombaSmashedState)
            {
                deathTimer++;
            }
            if (!isHit)
            {
                location = physics.Update(location);
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
