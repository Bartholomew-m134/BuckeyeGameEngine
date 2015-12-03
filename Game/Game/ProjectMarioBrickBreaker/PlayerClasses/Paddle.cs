using Game.Interfaces;
using Game.SpriteFactories;
using Game.Utilities;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectMarioBrickBreaker.PlayerClasses
{
    public class Paddle : IPaddle
    {
        private Game1 myGame;
        private ISprite paddleSprite;
        private Vector2 location;
        private IPhysics physics;
        

        public Paddle(Game1 game)
        {
            
            myGame = game;
            paddleSprite = MarioBrickBreakerSpriteFactory.CreateMushroomPaddleSprite();
            physics = new MarioGamePhysics();
            physics.Acceleration = Vector2.Zero;
           
        }

        public void Update()
        {
            location = physics.Update(location);
        }

        public void Draw(ICamera camera)
        {
            paddleSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return paddleSprite; }
            set { paddleSprite = value; }
        }

        public IPhysics Physics
        {
            get { return physics; }
        }

        public void Left()
        {
            physics.Velocity = new Vector2(ObjectPhysicsConstants.INITIALXMINVELOCITY, 0);
        }

        public void Right()
        {
            physics.Velocity = new Vector2(ObjectPhysicsConstants.INITIALXMAXVELOCITY, 0);
        }

        public void ReleaseBall()
        {
            throw new NotImplementedException();
        }

        public bool IsDead
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public void MushroomPowerUp()
        {
            paddleSprite = MarioBrickBreakerSpriteFactory.CreateMushroomPaddleSprite();
        }
    }
}
