using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Items
{
    public class Flower : IItem
    {
        private Game1 myGame;
        private ISprite flowerSprite;
        private Vector2 location;
        private bool isVisible;
        public Flower(Game1 game)
        {
            myGame = game;
            flowerSprite = ItemsSpriteFactory.CreateFlowerSprite();
            isVisible = true;
        }

        public void Update()
        {
            flowerSprite.Update();
        }

        public void Draw() {
            if (isVisible)
            {
            flowerSprite.Draw(myGame.spriteBatch, location);
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
            get { return flowerSprite; }
            set { flowerSprite = value; }
        }

    }

}
