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
    class SingleCloud:IGameObject
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
       
        public void Draw() {
            
                singleCloudSprite.Draw(myGame.spriteBatch, location);
            
        }


        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite GetSetSprite
        {
            get { return singleCloudSprite; }
            set { singleCloudSprite = value; }
        }

        public ObjectPhysics Physics
        {
            get { return null; }
        }
    }
}
