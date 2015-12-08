using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using Game.ProjectBuckeye.EnemyClasses.WolverineChuckStates;
using Game.ProjectBuckeye.FootballClasses;

namespace Game.ProjectBuckeye.EnemyClasses
{
    public class WolverineChuck : IWolverine
    {
        private ISprite sprite;
        private IWolverineState state;
        private Vector2 location;
        private bool isHit;
        private bool canDealDamage;
        private IPhysics physics;
        private Game1 myGame;
        private int deathTimer = 0;
        private int hp = 35;
        private int throwTimer = 0;
        private FootballSpawner spawner;
        private bool isGrounded;

        private int stepCounter = 0;

        public WolverineChuck(Game1 game)
        {
            myGame = game;
            isHit = false;
            canDealDamage = true;
            physics = new MarioGamePhysics();
            state = new WolverineChuckIdleLeftState(this);
            spawner = new FootballSpawner(myGame);
        }

        public void Hit()
        {
            hp--;
            if (hp <= 0)
            {
                isHit = true;
                BuckeyeVictoryTransition.TransitionToVictory(myGame);
            }
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
                HandleAI();
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
        }

        private bool FacingRight()
        {
            bool movingRight = false;
            if (this.state is WolverineChuckCharginRightState || this.state is WolverineChuckIdleRightState)
                movingRight = true;
            return movingRight;
        }

        public void Idle()
        {
        }

        private void HandleAI()
        {
            if (hp <= 35 && hp >= 21)
            {
                Chuck();
            }
            else if (hp <= 20 && hp > 10)
            {
                state.Move();
                Charge();
            }
            else if (hp <= 10)
            {
                state.Move();
                ChargeandChuck();
            }
        }

        private void Chuck()
        {
            if (throwTimer > 10)
            {
                spawner.ReleaseFootball(location, FacingRight(), true, this, ProjectileConstants.CHUCK_PHASE_1_FOOTBALL);
                throwTimer = 0;
            }
            throwTimer++;

            if (isGrounded)
            {
                physics.Velocity = new Vector2(physics.Velocity.X, -8);
                isGrounded = false;
            }
        }

        private void Charge()
        {
            stepCounter++;
            if (stepCounter > 56)
            {
                ShiftDirection();
                stepCounter = 0;
            }
        }

        private void ChargeandChuck()
        {
            if (throwTimer > 15)
            {
                spawner.ReleaseFootball(location, FacingRight(), true, this, ProjectileConstants.CHUCK_PHASE_2_FOOTBALL);
                throwTimer = 0;
            }
            throwTimer++;

            stepCounter++;
            if (stepCounter > 56)
            {
                ShiftDirection();
                stepCounter = 0;
            }
        }

        public bool IsGrounded
        {
            get { return isGrounded; }
            set { isGrounded = value; }
        }
    }
}
