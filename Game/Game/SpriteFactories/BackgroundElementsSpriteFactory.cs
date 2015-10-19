using Game.Background_Elements.BackgroundElementSprites;
using Game.Interfaces;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.SpriteFactories
{
    public static class BackgroundElementsSpriteFactory
    {
        private static Texture2D backgroundElementsSpriteSheet;

        public static void Load(ContentManager content)
        {
            backgroundElementsSpriteSheet = content.Load<Texture2D>("ScenarySpriteSheet");

        }

        public static void Unload()
        {

        }
        public static ISprite CreateBigHillSprite()
        {
            return new BigHillSprite(backgroundElementsSpriteSheet);
        }

        public static ISprite CreateSmallHillSprite()
        {
            return new SmallHillSprite(backgroundElementsSpriteSheet);
        }

        public static ISprite CreateSingleCloudSprite()
        {
            return new SingleCloudSprite(backgroundElementsSpriteSheet);
        }

        public static ISprite CreateTripleCloudSprite()
        {
            return new TripleCloudSprite(backgroundElementsSpriteSheet);
        }

        public static ISprite CreateSingleBushSprite()
        {
            return new SingleBushSprite(backgroundElementsSpriteSheet);
        }

        public static ISprite CreateTripleBushSprite()
        {
            return new TripleBushSprite(backgroundElementsSpriteSheet);
        }
    }
}
