using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Game.Enemies.GoombaClasses.GoombaSprites;

namespace Game.SpriteFactories
{
    public static class EnemySpriteFactory
    {
        private static Texture2D enemySpriteSheet;

        public static void Load(ContentManager content, GraphicsDevice device)
        {
            enemySpriteSheet = content.Load<Texture2D>("EnemiesSpriteSheet");
        }

        public static void Unload()
        {

        }

        public static ISprite CreateGoombaFlippedSprite(Game1 game)
        {
            return new GoombaSmashedSprite(enemySpriteSheet, game);
        }

        public static ISprite CreateGoombaSmashedSprite(Game1 game)
        {
            return new GoombaFlippedSprite(enemySpriteSheet, game);
        }

        public static ISprite CreateGoombaWalkingLeftSprite(Game1 game)
        {
            return new GoombaWalkingLeftSprite(enemySpriteSheet, game);
        }

        public static ISprite CreateGoombaWalkingRightSprite(Game1 game)
        {
            return new GoombaWalkingRightSprite(enemySpriteSheet, game);
        }

        public static ISprite CreateGoombaWalkingRightSprite(Game1 game)
        {
            return new GoombaWalkingRightSprite(enemySpriteSheet, game);
        }
    }
}
