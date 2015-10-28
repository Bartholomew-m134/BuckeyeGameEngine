using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.SpriteFactories;
using Game.Interfaces;
using Game.Utilities;

namespace Game.Projectiles
{
    public class LeftFire : IProjectile
    {
        private Game1 myGame;
        private ISprite FireSprite;
        private Vector2 location;
        private ObjectPhysics physics;
        private FireBallFactory factory;

        public LeftFire(FireBallFactory factory, Game1 game)
        {
            myGame = game;
            FireSprite = ProjectileSpriteFactory.CreateFireSprite();
            physics = new ObjectPhysics();
            physics.Velocity = new Vector2(-15, physics.Velocity.Y);
            this.factory = factory;
        }

        public void Update()
        {
            
            FireSprite.Update();
            location = physics.Update(location);
        }

        public void Draw(ICamera camera)
        {
            FireSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public void Explode()
        {
            location.Y += 2000;
            physics.Acceleration = Vector2.Zero;
            physics.Velocity = Vector2.Zero;
            factory.ReturnFireBall();
        }

        public void Bounce()
        {
            physics.Velocity = new Vector2(physics.Velocity.X, -physics.Velocity.Y);
        }

        public void ReturnObject()
        {
            factory.ReturnFireBall();
        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return FireSprite; }
            set { FireSprite = value; }
        }

        public ObjectPhysics Physics
        {
            get { return physics; }
        }

    }
}