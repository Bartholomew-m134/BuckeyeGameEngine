using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Game.Enemies.GoombaClasses.GoombaSprites;
using Game.Enemies.GreenKoopaClasses.GreenKoopaSprites;

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

        public static ISprite CreateGreenKoopaEmergingFromShellSprite(Game1 game)
        {
            return new GreenKoopaEmergingFromShellSprite(enemySpriteSheet, game);
        }

        public static ISprite CreateGreenKoopaFlippedInShellSprite(Game1 game)
        {
            return new GreenKoopaFlippedInShellSprite(enemySpriteSheet, game);
        }

        public static ISprite CreateGreenKoopaHidingInShellSprite(Game1 game)
        {
            return new GreenKoopaHidingInShellSprite(enemySpriteSheet, game);
        }

        public static ISprite CreateGreenKoopaWalkingLeftSprite(Game1 game)
        {
            return new GreenKoopaWalkingLeftSprite(enemySpriteSheet, game);
        }

        public static ISprite CreateGreenKoopaWalkingRightSprite(Game1 game)
        {
            return new GreenKoopaWalkingRightSprite(enemySpriteSheet, game);
        }

    }
}
