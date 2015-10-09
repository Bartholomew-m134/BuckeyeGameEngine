using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Background_Elements
{
    class TripleBush:IGameObject
    {

        private Game1 myGame;
        private ISprite tripleBushSprite;
        private Vector2 location;
        private bool isVisible;

        public TripleBush(Game1 game)
        {
            myGame = game;
            tripleBushSprite = BackgroundElementsSpriteFactory.CreateTripleBushSprite();
            isVisible = true;
        }

        public void Update()
        {
            tripleBushSprite.Update();
        }
       
        public void Draw() {
            if (isVisible)
            {
                tripleBushSprite.Draw(myGame.spriteBatch, location);
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
            get { return tripleBushSprite; }
        }
    }
}
