using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.SpriteFactories;

namespace Game.Items
{
    public class Coin : IItem
    {
        private Game1 myGame;
        private ISprite coinSprite;
        private Vector2 location;
        private bool isVisible;

        public Coin(Game1 game)
        {
            myGame = game;
            coinSprite = ItemsSpriteFactory.CreateCoinSprite();
            isVisible = true;
        }

        public void Update()
        {
            coinSprite.Update();
        }
       
        public void Draw() {
            if (isVisible)
            {
                coinSprite.Draw(myGame.spriteBatch, location);
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
            get { return coinSprite; }
            set { coinSprite = value; }
        }
    }
}
