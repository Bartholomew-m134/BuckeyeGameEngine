using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.SpriteFactories;
using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;

namespace Game.Lemming
{
    class Endblock : IGameObject
    {
        private Game1 myGame;
        private ISprite endblockSprite;
        private Vector2 location;
        private IPhysics physics;


        public Endblock(Game1 game)
        {
            myGame = game;
            endblockSprite = LemmingSpriteFactory.CreateEndblockSprite();
            physics = new MarioGamePhysics();
            physics.Acceleration = Vector2.Zero;
            physics.Velocity = Vector2.Zero;
        }

        public void Update()
        {
            endblockSprite.Update();
            location = physics.Update(location);
        }

        public void Draw(ICamera camera)
        {
            endblockSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

      
        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return endblockSprite; }
            set { endblockSprite = value; }
        }

        public IPhysics Physics
        {
            get { return physics; }
        }


    }
}