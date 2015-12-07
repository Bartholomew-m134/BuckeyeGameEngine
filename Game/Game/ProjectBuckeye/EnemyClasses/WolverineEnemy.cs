using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using Game.ProjectBuckeye.EnemyClasses.WolverineStates;

namespace Game.ProjectBuckeye.EnemyClasses
{
    public class WolverineEnemy : IWolverine
    {
        private ISprite sprite;
        private IWolverineState state;
        private Vector2 location;
        private bool isHit;
        private bool canDealDamage;
        private IPhysics physics;
        private Game1 myGame;
        private int deathTimer = 0;
        private bool isGrounded;

        public WolverineEnemy(Game1 game)
        {
            myGame = game;
            isHit = false;
            canDealDamage = true;
            physics = new MarioGamePhysics();
            state = new WolverineMovingLeftState(this);
        }

        public void Hit()
        {
            state.Damage();
        }

        public void ShiftDirection()
        {
            state.DirectionChange();
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

        public void Update()
        {
            if (isHit && deathTimer == IEnemyObjectConstants.STOMPEDGOOMBADELAYTIME)
            {
                location.Y += IEnemyObjectConstants.VANISH;
                deathTimer = 0;
            }
            else if (isHit)
            {
                deathTimer++;
            }
            else if (!isHit)
            {
                location = physics.Update(location);
            }
            state.Update();  
        }

        public void Draw(ICamera camera)
        {
            sprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
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

        public IPhysics Physics
        {
            get { return physics; }
        }


        public IWolverineState State
        {
            get { return state; }
            set { state = value; }
        }


        public void Throw()
        {
        }


        public void Idle()
        {
        }


        public bool IsGrounded
        {
            get { return isGrounded; }
            set { isGrounded = value; }
        }
    }
}
