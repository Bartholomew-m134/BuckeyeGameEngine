using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using Game.ProjectBuckeye.EnemyClasses.WolverineStates;
using Game.ProjectBuckeye.FootballClasses;

namespace Game.ProjectBuckeye.EnemyClasses
{
    public class ThrowingWolverineEnemy : IWolverine
    {
        private ISprite sprite;
        private IWolverineState state;
        private Vector2 location;
        private bool isHit;
        private bool canDealDamage;
        private IPhysics physics;
        private Game1 myGame;
        private int deathTimer = 0;
        private int throwTimer = 0;
        private FootballSpawner spawner;
        private bool isGrounded;

        public ThrowingWolverineEnemy(Game1 game)
        {
            myGame = game;
            isHit = false;
            canDealDamage = true;
            physics = new MarioGamePhysics();
            state = new WolverineMovingLeftState(this);
            spawner = new FootballSpawner(myGame);
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
                throwTimer++;
                location = physics.Update(location);
                if (throwTimer == 30)
                {
                    Toss();
                    throwTimer = 0;
                }
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


        public void Toss()
        {
            spawner.ReleaseFootball(location, FacingRight(), true, this, ProjectileConstants.ENEMY_FOOTBALL);
        }

        private bool FacingRight()
        {
            bool movingRight = false;
            if (this.state is WolverineMovingRightState)
                movingRight = true;
            return movingRight;
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
