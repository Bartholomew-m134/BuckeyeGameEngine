using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Game.Mario.MarioSprites;

namespace Game.SpriteFactories
{
    public static class MarioSpriteFactory
    {
        private static Texture2D marioSpriteSheet;

        public static void Load(ContentManager content, GraphicsDevice device)
        {
            marioSpriteSheet = content.Load<Texture2D>("MarioSpriteSheet");

        }

        public static void Unload()
        {

        }

        public static ISprite CreateDeadSprite(Game1 game)
        {
            return new DeadSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateFireLeftCrouchingSprite(Game1 game)
        {
            return new FireLeftCrouchingSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateFireLeftIdleSprite(Game1 game)
        {
            return new FireLeftIdleSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateFireLeftJumpingSprite(Game1 game)
        {
            return new FireLeftJumpingSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateFireLeftRunningSprite(Game1 game)
        {
            return new FireLeftRunningSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateFireRightCrouchingSprite(Game1 game)
        {
            return new FireRightCrouchingSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateFireRightIdleSprite(Game1 game)
        {
            return new FireRightIdleSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateFireRightJumpingSprite(Game1 game)
        {
            return new FireRightJumpingSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateFireRightRunningSprite(Game1 game)
        {
            return new FireRightRunningSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateNormalLeftCrouchingSprite(Game1 game)
        {
            return new NormalLeftCrouchingSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateNormalLeftIdleSprite(Game1 game)
        {
            return new NormalLeftIdleSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateNormalLeftJumpingSprite(Game1 game)
        {
            return new NormalLeftJumpingSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateNormalLeftRunningSprite(Game1 game)
        {
            return new NormalLeftRunningSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateNormalRightCrouchingSprite(Game1 game)
        {
            return new NormalRightCrouchingSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateNormalRightIdleSprite(Game1 game)
        {
            return new NormalRightIdleSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateNormalRightJumpingSprite(Game1 game)
        {
            return new NormalRightJumpingSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateNormalRightRunningSprite(Game1 game)
        {
            return new NormalRightRunningSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateSmallLeftIdleSprite(Game1 game)
        {
            return new SmallLeftIdleSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateSmallLeftJumpingSprite(Game1 game)
        {
            return new SmallLeftJumpingSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateSmallLeftRunningSprite(Game1 game)
        {
            return new SmallLeftRunningSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateSmallRightIdleSprite(Game1 game)
        {
            return new SmallRightIdleSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateSmallRightJumpingSprite(Game1 game)
        {
            return new SmallRightJumpingSprite(marioSpriteSheet, game);
        }

        public static ISprite CreateSmallRightRunningSprite(Game1 game)
        {
            return new SmallRightRunningSprite(marioSpriteSheet, game);
        }
    }
}
