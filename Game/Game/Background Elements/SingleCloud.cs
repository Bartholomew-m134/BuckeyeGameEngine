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
    class SingleCloud : IScenery
    {
        private Game1 myGame;
        private ISprite singleCloudSprite;
        private Vector2 location;


        public SingleCloud(Game1 game)
        {
            myGame = game;
            singleCloudSprite = BackgroundElementsSpriteFactory.CreateSingleCloudSprite();

        }

        public void Update()
        {
            singleCloudSprite.Update();
        }

        public void Draw(ICamera camera)
        {
            singleCloudSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }


        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return singleCloudSprite; }
            set { singleCloudSprite = value; }
        }

        public IPhysics Physics
        {
            get { return null; }
        }
    }
}
