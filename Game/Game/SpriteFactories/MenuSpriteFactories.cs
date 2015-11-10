﻿using Game.Background_Elements.BackgroundElementSprites;
using Game.Interfaces;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.SpriteFactories
{
    public static class MenuSpriteFactory
    {
        private static Texture2D logoSpriteSheet;
        private static Texture2D startSpriteSheet;
        private static SpriteFont spriteFont;
        private static SpriteFont hudFont;

        public static void Load(ContentManager content)
        {
            logoSpriteSheet = content.Load<Texture2D>("BGENamesVersion");
            startSpriteSheet = content.Load<Texture2D>("BGEPressStartVersion");
            spriteFont = content.Load<SpriteFont>("ScoreFont");
            hudFont = content.Load<SpriteFont>("HUDFont");
        }

        public static void Unload()
        {

        }

        public static ISprite CreateLogoSprite()
        {
            return new LogoSprite(logoSpriteSheet);
        }

        public static ISprite CreateStartSprite()
        {
            return new StartSprite(startSpriteSheet);
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