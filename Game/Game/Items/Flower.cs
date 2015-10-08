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
            location = new Vector2(130, 80);
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
        }
        Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

    }

}
