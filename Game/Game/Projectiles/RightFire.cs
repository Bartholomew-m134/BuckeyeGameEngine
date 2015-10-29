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
    public class RightFire : IProjectile
    {
        private Game1 myGame;
        private ISprite FireSprite;
        private Vector2 location;
        private ObjectPhysics physics;
        private bool isExploded;
        private FireBallFactory factory;

        public RightFire(FireBallFactory factory, Game1 game)
        {
            myGame = game;
            FireSprite = ProjectileSpriteFactory.CreateFireSprite();
            physics = new ObjectPhysics();
            physics.Velocity = new Vector2(10, physics.Velocity.Y);
            physics.VelocityMaximum = new Vector2(10, physics.VelocityMaximum.Y);
            isExploded = false;
            this.factory = factory;
        }

        public void Update()
        {
            if (!isExploded)
            {
                FireSprite.Update();
                location = physics.Update(location);
            }
            else {
                location.Y = 2000;
            }
        }

        public void Draw(ICamera camera)
        {
            FireSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public void Explode()
        {
            FireSprite = ProjectileSpriteFactory.CreateExplodingFireSprite();
            physics.Acceleration = Vector2.Zero;
            physics.Velocity = Vector2.Zero;
            isExploded = true;
        }

        public void Bounce()
        {
            physics.Velocity = new Vector2(physics.Velocity.X, -2);
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
