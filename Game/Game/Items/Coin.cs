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

        public Coin(Game1 game)
        {
            myGame = game;
            coinSprite = ItemsSpriteFactory.CreateCoinSprite(game);
            location = new Vector2(30, 80);

        }

        public void Update()
        {
            coinSprite.Update();
        }

        public void Draw() {
            coinSprite.Draw(myGame.spriteBatch, location);
        }
    }
}
