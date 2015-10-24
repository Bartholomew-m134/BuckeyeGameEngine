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

        public static ISprite CreateRedMushroomSprite()
        {
            return new RedMushroomSprite(itemSpriteSheet);
        }

        public static ISprite CreateGreenMushroomSprite()
        {
            return new GreenMushroomSprite(itemSpriteSheet);
        }

        public static ISprite CreateCoinSprite()
        {
            return new CoinSprite(itemSpriteSheet);
        }

        public static ISprite CreateFlowerSprite()
        {
            return new FlowerSprite(itemSpriteSheet);
        }

        public static ISprite CreateStarSprite()
        {
            return new StarSprite(itemSpriteSheet);
        }
    }
}
