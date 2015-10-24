using Game.Interfaces;
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

        public static void Load(ContentManager content)
        {
            itemSpriteSheet = content.Load<Texture2D>("ItemsSpriteSheet");
            
        }

        public static void Unload()
        {

        }

        public static IItemSprite CreateRedMushroomSprite()
        {
            return new RedMushroomSprite(itemSpriteSheet);
        }

        public static IItemSprite CreateGreenMushroomSprite()
        {
            return new GreenMushroomSprite(itemSpriteSheet);
        }

        public static IItemSprite CreateCoinSprite() {
            return new CoinSprite(itemSpriteSheet);
        }

        public static IItemSprite CreateFlowerSprite()
        {
            return new FlowerSprite(itemSpriteSheet);
        }

        public static IItemSprite CreateStarSprite()
        {
            return new StarSprite(itemSpriteSheet);
        }
    }
}
