using Game.Interfaces;
using Game.ProjectPacMario.EnemyClasses.EnemyStates;
using Game.ProjectPacMario.Utilities;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectPacMario.EnemyClasses
{
    public class Boo : IEnemy
    {
        public IBooState state;
        private ISprite sprite;
        private Game1 myGame;
        private Vector2 location;
        private bool canDealDamage = true;
        private IPhysics physics;
        private int deathTimer = 0;
        private bool isFlipped = false;
        private bool isHit = false;
        private Vector2 resetLocation;

        public Boo(Game1 game, Vector2 booResetLocation)
        {
            myGame = game;
            physics = new PacMarioGamePhysics();
            state = new UpPatrolingBooState(this);
            resetLocation = booResetLocation;
        }

        public void Hit()
        {
            state.Die();
        }

        public void Left()
        {
            state = new LeftPatrolingBooState(this);
        }
        public void Right()
        {
            state = new RightPatrolingBooState(this);
        }
        public void Up()
        {
            state = new UpPatrolingBooState(this);
        }
        public void Down()
        {
            state = new DownPatrolingBooState(this);
        }

        public void Flipped()
        {

        }
        public void ShiftDirection()
        {

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
            if (state is DeadBooState && deathTimer == IEnemyObjectConstants.STOMPEDGOOMBADELAYTIME)
            {
                location = resetLocation;
                deathTimer = 0;
                state = new UpPatrolingBooState(this);
            }
            else if (state is DeadBooState)
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

        public IPhysics Physics
        {
            get { return physics; }
        }
    }
}
