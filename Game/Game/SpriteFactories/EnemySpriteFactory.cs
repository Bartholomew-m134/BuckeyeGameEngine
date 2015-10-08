using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Game.Enemies.GoombaClasses.GoombaSprites;
using Game.Enemies.KoopaClasses.GreenKoopaSprites;

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

        public static ISprite CreateGoombaFlippedSprite()
        {
            return new GoombaFlippedSprite(enemySpriteSheet);
        }

        public static ISprite CreateGoombaSmashedSprite()
        {
            return new GoombaSmashedSprite(enemySpriteSheet);
        }

        public static ISprite CreateGoombaWalkingLeftSprite()
        {
            return new GoombaWalkingLeftSprite(enemySpriteSheet);
        }

        public static ISprite CreateGoombaWalkingRightSprite()
        {
            return new GoombaWalkingRightSprite(enemySpriteSheet);
        }

        public static ISprite CreateGreenKoopaEmergingFromShellSprite()
        {
            return new GreenKoopaEmergingFromShellSprite(enemySpriteSheet);
        }

        public static ISprite CreateGreenKoopaFlippedInShellSprite()
        {
            return new GreenKoopaFlippedInShellSprite(enemySpriteSheet);
        }

        public static ISprite CreateGreenKoopaHidingInShellSprite()
        {
            return new GreenKoopaHidingInShellSprite(enemySpriteSheet);
        }

        public static ISprite CreateGreenKoopaWalkingLeftSprite()
        {
            return new GreenKoopaWalkingLeftSprite(enemySpriteSheet);
        }

        public static ISprite CreateGreenKoopaWalkingRightSprite()
        {
            return new GreenKoopaWalkingRightSprite(enemySpriteSheet);
        }

    }
}
