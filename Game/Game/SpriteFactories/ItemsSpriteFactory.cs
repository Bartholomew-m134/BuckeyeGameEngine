using Game.Items.ItemSprites;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.SpriteFactories
{
    public static class ItemsSpriteFactory
    {
        private static Texture2D itemSpriteSheet;

        public static void Load(ContentManager content, GraphicsDevice device)
        {
            itemSpriteSheet = content.Load<Texture2D>("ItemsSpriteSheet");
            
        }

        public static void Unload()
        {

        }

        public static ISprite CreateRedMushroomSprite(Game1 game) {
            return new RedMushroomSprite(itemSpriteSheet, game);
        }

        public static ISprite CreateGreenMushroomSprite(Game1 game) {
            return new GreenMushroomSprite(itemSpriteSheet, game);
        }

        public static ISprite CreateCoinSprite(Game1 game) {
            return new CoinSprite(itemSpriteSheet, game);
        }

        public static ISprite CreateFlowerSprite(Game1 game) {
            return new FlowerSprite(itemSpriteSheet, game);
        }

        public static ISprite CreateStarSprite(Game1 game) {
            return new StarSprite(itemSpriteSheet, game);
        }
    }
}
