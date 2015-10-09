using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Background_Elements
{
    class TripleCloud:IGameObject
    {
        private Game1 myGame;
        private ISprite tripleCloudSprite;
        private Vector2 location;
        private bool isVisible;

        public TripleCloud(Game1 game)
        {
            myGame = game;
            tripleCloudSprite = BackgroundElementsSpriteFactory.CreateTripleCloudSprite();
            isVisible = true;
        }

        public void Update()
        {
            tripleCloudSprite.Update();
        }
       
        public void Draw() {
            if (isVisible)
            {
                tripleCloudSprite.Draw(myGame.spriteBatch, location);
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
            get { return tripleCloudSprite; }
        }
    }
}
