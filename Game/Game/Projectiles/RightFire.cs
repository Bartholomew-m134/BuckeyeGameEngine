using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.SpriteFactories;
using Game.Interfaces;
using Game.Utilities;

namespace Game.Items
{
    public class RightFire : IProjectile
    {
        private Game1 myGame;
        private ISprite FireSprite;
        private Vector2 location;
        private ObjectPhysics physics;

        public RightFire(Game1 game)
        {
            myGame = game;
            FireSprite = ProjectileSpriteFactory.CreateFireSprite();
            physics = new ObjectPhysics();
            physics.Velocity = new Vector2(15, physics.Velocity.Y);
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
        }

        public void Bounce()
        {
            physics.Velocity = new Vector2(physics.Velocity.X, -physics.Velocity.Y);
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
