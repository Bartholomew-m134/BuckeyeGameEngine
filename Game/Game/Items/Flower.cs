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

        public Flower(Game1 game)
        {
            myGame = game;
            flowerSprite = ItemsSpriteFactory.CreateFlowerSprite(game);
            location = new Vector2(130, 80);

        }

        public void Update()
        {
            flowerSprite.Update();
        }

        public void Draw() {
            flowerSprite.Draw(myGame.spriteBatch, location);
        }

    }

}
