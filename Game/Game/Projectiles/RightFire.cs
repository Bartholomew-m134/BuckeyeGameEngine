using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.SpriteFactories;
using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;
namespace Game.Projectiles
{
    public class RightFire : IProjectile
    {
        private Game1 myGame;
        private ISprite FireSprite;
        private Vector2 location;
        private IPhysics physics;
        private bool isExploded;
        private FireBallSpawner factory;

        public RightFire(FireBallSpawner factory, Game1 game)
        {
            myGame = game;
            FireSprite = ProjectileSpriteFactory.CreateFireSprite();
            physics = new MarioGamePhysics();
            physics.Velocity = new Vector2(ProjectileConstants.RIGHTFIREINITIALXVELOCITY, physics.Velocity.Y);
            physics.VelocityMaximum = new Vector2(ProjectileConstants.RIGHTFIREINITIALXVELOCITY, physics.VelocityMaximum.Y);
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
                location.Y = ProjectileConstants.FIREBALLHELL;
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
            physics.Velocity = new Vector2(physics.Velocity.X, ProjectileConstants.FIREBALLBOUNCEYVELOCITY);
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

        public IPhysics Physics
        {
            get { return physics; }
        }

    }
}
