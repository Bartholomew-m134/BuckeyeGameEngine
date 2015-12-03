using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.SpriteFactories;
using Game.Utilities;
using Game.Utilities.Constants;

namespace Game.ProjectBuckeye.FootballClasses
{
    public class Football : IProjectile
    {
        private Game1 myGame;
        private ISprite sprite;
        private Vector2 location;
        private IPhysics physics;
        private bool isExploded;
        private FootballSpawner spawner;
        private bool isHostile;

        public Football(FootballSpawner spawner, Game1 game, bool throwingRight, bool isHostile)
        {
            myGame = game;
            sprite = ProjectileSpriteFactory.CreateFootballSprite();
            physics = new MarioGamePhysics();
            physics.Acceleration = new Vector2(0, 0);
            if (throwingRight)
            {
                physics.VelocityMaximum = new Vector2(20, 0);
                physics.Velocity = new Vector2(20, 0);
            }
            else
            {
                physics.VelocityMinimum = new Vector2(-20, 0);
                physics.Velocity = new Vector2(-20, 0);
            }

            isExploded = false;
            this.isHostile = isHostile;
            this.spawner = spawner;
        }

        public void Explode()
        {
            physics.Acceleration = Vector2.Zero;
            physics.Velocity = Vector2.Zero;
            isExploded = true;
        }

        public void Bounce()
        {
        }

        public void ReturnObject()
        {
            spawner.ReturnFootball();
        }

        public void Update()
        {
            if (!isExploded)
            {
                sprite.Update();
                location = physics.Update(location);
            }
            else
            {
                location.Y = ProjectileConstants.FIREBALLHELL;
            }
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


        public bool IsHostile()
        {
            return isHostile;
        }
    }
}
