using Game.Interfaces;
using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities;

namespace Game.Background_Elements
{
    class TripleCloud:IGameObject
    {
        private Game1 myGame;
        private ISprite tripleCloudSprite;
        private Vector2 location;

        public TripleCloud(Game1 game)
        {
            myGame = game;
            tripleCloudSprite = BackgroundElementsSpriteFactory.CreateTripleCloudSprite();
        }

        public void Update()
        {
            tripleCloudSprite.Update();
        }

        public void Draw(ICamera camera)
        {
            tripleCloudSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }


        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite GetSetSprite
        {
            get { return tripleCloudSprite; }
            set { tripleCloudSprite = value; }
        }

        public ObjectPhysics Physics
        {
            get { return null; }
        }
    }
}
