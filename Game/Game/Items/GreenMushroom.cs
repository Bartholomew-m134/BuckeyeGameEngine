using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Items
{
    public class GreenMushroom : IItem
    {
        private Game1 myGame;
        private ISprite greenMushroomSprite;
        private Vector2 location;

        public GreenMushroom(Game1 game)
        {
            myGame = game;
            greenMushroomSprite = ItemsSpriteFactory.CreateGreenMushroomSprite(game);
            location = new Vector2(230, 80);

        }

        public void Update()
        {
            greenMushroomSprite.Update();
        }

        public void Draw() {
            greenMushroomSprite.Draw(myGame.spriteBatch, location);
        }
    }
}
