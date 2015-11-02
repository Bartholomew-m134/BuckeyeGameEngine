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
        private static Texture2D logoSpriteSheet;
        private static SpriteFont spriteFont;
        private static SpriteFont hudFont;

        public static void Load(ContentManager content)
        {
            backgroundElementsSpriteSheet = content.Load<Texture2D>("ScenarySpriteSheet");
            logoSpriteSheet = content.Load<Texture2D>("BGENamesVersion");
            spriteFont = content.Load<SpriteFont>("ScoreFont");
            hudFont = content.Load<SpriteFont>("HUDFont");


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
        public static ISprite CreateCastleSprite()
        {
            return new CastleSprite(backgroundElementsSpriteSheet);
        }
        public static ISprite CreateLogoSprite()
        {
            return new LogoSprite(logoSpriteSheet);
        }
        public static SpriteFont CreateScoreFont()
        {
            return spriteFont;
        }
        public static SpriteFont CreateHUDFont()
        {
            return hudFont;
        }
    }
}
