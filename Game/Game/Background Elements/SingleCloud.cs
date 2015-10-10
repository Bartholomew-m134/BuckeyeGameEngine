using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Background_Elements
{
    class SingleCloud:IGameObject
    {
        private Game1 myGame;
        private ISprite singleCloudSprite;
        private Vector2 location;
        private bool isVisible;

        public SingleCloud(Game1 game)
        {
            myGame = game;
            singleCloudSprite = BackgroundElementsSpriteFactory.CreateSingleCloudSprite();
            isVisible = true;
        }

        public void Update()
        {
            singleCloudSprite.Update();
        }
       
        public void Draw() {
            if (isVisible)
            {
                singleCloudSprite.Draw(myGame.spriteBatch, location);
            }
        }

        public void Disappear() {
            isVisible = false;
            location.Y -= 1000;
        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite GetSprite
        {
            get { return singleCloudSprite; }
            set { singleCloudSprite = value; }
        }
    }
}
