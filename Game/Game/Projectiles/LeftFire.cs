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
    public class LeftFire : IProjectile
    {
        private Game1 myGame;
        private IProjectile fire;
        private ISprite FireSprite;
        private Vector2 location;
        private ObjectPhysics physics;
        private bool isReleased;

        public LeftFire(Game1 game)
        {
            isReleased = false;
            myGame = game;
            FireSprite = ProjectileSpriteFactory.CreateFireSprite();
            physics = new ObjectPhysics();
            physics.Acceleration = Vector2.Zero;
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

        public void Release(Vector2 location)
        {
            if (!isReleased)
            {
                isReleased = true;
                physics.ResetPhysics();
                physics.Velocity = new Vector2(-10, 10);
                physics.Acceleration = new Vector2(0, 0); 
            }
        }

        public void ReverseDirection()
        {
            float Y = this.physics.Velocity.Y;
            float X = this.physics.Velocity.X;
            this.physics.Velocity = new Vector2(-X,Y);
        }

        public void Bounce()
        {
            float X = this.physics.Velocity.X;
            this.physics.ResetY();
            this.physics.Velocity = new Vector2(X, -5);
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