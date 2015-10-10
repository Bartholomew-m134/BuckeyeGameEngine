using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Items
{
    public class Star : IItem
    {
        private Game1 myGame;
        private ISprite starSprite;
        private Vector2 location;
        private bool isVisible;
        public Star(Game1 game)
        {
            myGame = game;
            starSprite = ItemsSpriteFactory.CreateStarSprite();
            isVisible = true;
        }

        public void Update()
        {
            starSprite.Update();
        }

        public void Draw() {
            if (isVisible)
            {
            starSprite.Draw(myGame.spriteBatch, location);
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
            get { return starSprite; }
            set { starSprite = value; }
        }

    }
}
