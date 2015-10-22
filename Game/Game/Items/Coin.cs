using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.SpriteFactories;
using Game.Interfaces;

namespace Game.Items
{
    public class Coin : IItem
    {
        private Game1 myGame;
        private ISprite coinSprite;
        private Vector2 location;

        public Coin(Game1 game)
        {
            myGame = game;
            coinSprite = ItemsSpriteFactory.CreateCoinSprite();
        }

        public void Update()
        {
            coinSprite.Update();
        }

        public void Draw(ICamera camera)
        {
            coinSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public void Disappear() {
            location.Y -= 2000;
        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite GetSetSprite
        {
            get { return coinSprite; }
            set { coinSprite = value; }
        }
    }
}
