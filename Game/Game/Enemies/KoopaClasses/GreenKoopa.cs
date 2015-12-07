using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Enemies.KoopaClasses.KoopaStates;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;

namespace Game.Enemies.KoopaClasses
{
    public class GreenKoopa : IEnemy
    {
        public IKoopaState state;
        public int weaponizedShellKillStreak;
        private ISprite sprite;
        private Game1 myGame;
        private Vector2 location;
        private bool canDealDamage = true;
        private int inShellTimer = 0;
        private IPhysics physics;
        private bool isFlipped = false;
        private bool isHit = false;
        private bool isWeaponized = false;

        public GreenKoopa(Game1 game)
        {
            myGame = game;
            physics = new MarioGamePhysics();
            physics.VelocityMaximum = new Vector2(IEnemyObjectConstants.KOOPAMAXVELOCITY, physics.VelocityMaximum.Y);
            physics.VelocityMinimum = new Vector2(IEnemyObjectConstants.KOOPAMINVELOCITY, physics.VelocityMinimum.Y);
            state = new GreenKoopaWalkingLeftState(this);
            weaponizedShellKillStreak = 0;
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

        public bool IsWeaponized
        {
            get { return isWeaponized; }
            set { isWeaponized = value; }
        }

        public void Draw(ICamera camera)
        {
            sprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public void Update()
        {
            if (!isWeaponized && (state is GreenKoopaHidingInShellState || state is GreenKoopaEmergingFromShellState))
            {
                inShellTimer++;
            }
            if (inShellTimer == IEnemyObjectConstants.HIDINGINSHELLMAXTIME && state is GreenKoopaHidingInShellState)
            {
                state.KoopaEmergingFromShell();
                inShellTimer = 0;
            }
            else if (inShellTimer == IEnemyObjectConstants.EMERGINGFROMSHELLMAXTIME && state is GreenKoopaEmergingFromShellState)
            {
                weaponizedShellKillStreak = 0;
                state.KoopaChangeDirection();
                canDealDamage = true;
                isHit = false;
                inShellTimer = 0;
            }

            location = physics.Update(location);

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

        public IPhysics Physics
        {
            get {return physics;}
        }
    }
}
