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

        public static ISprite CreateDeadSprite()
        {
            return new DeadSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireLeftCrouchingSprite()
        {
            return new FireLeftCrouchingSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireLeftIdleSprite()
        {
            return new FireLeftIdleSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireLeftJumpingSprite()
        {
            return new FireLeftJumpingSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireLeftRunningSprite()
        {
            return new FireLeftRunningSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireRightCrouchingSprite()
        {
            return new FireRightCrouchingSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireRightIdleSprite()
        {
            return new FireRightIdleSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireRightJumpingSprite()
        {
            return new FireRightJumpingSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireRightRunningSprite()
        {
            return new FireRightRunningSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalLeftCrouchingSprite()
        {
            return new NormalLeftCrouchingSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalLeftIdleSprite()
        {
            return new NormalLeftIdleSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalLeftJumpingSprite()
        {
            return new NormalLeftJumpingSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalLeftRunningSprite()
        {
            return new NormalLeftRunningSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalRightCrouchingSprite()
        {
            return new NormalRightCrouchingSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalRightIdleSprite()
        {
            return new NormalRightIdleSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalRightJumpingSprite()
        {
            return new NormalRightJumpingSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalRightRunningSprite()
        {
            return new NormalRightRunningSprite(marioSpriteSheet);
        }

        public static ISprite CreateSmallLeftIdleSprite()
        {
            return new SmallLeftIdleSprite(marioSpriteSheet);
        }

        public static ISprite CreateSmallLeftJumpingSprite()
        {
            return new SmallLeftJumpingSprite(marioSpriteSheet);
        }

        public static ISprite CreateSmallLeftRunningSprite()
        {
            return new SmallLeftRunningSprite(marioSpriteSheet);
        }

        public static ISprite CreateSmallRightIdleSprite()
        {
            return new SmallRightIdleSprite(marioSpriteSheet);
        }

        public static ISprite CreateSmallRightJumpingSprite()
        {
            return new SmallRightJumpingSprite(marioSpriteSheet);
        }

        public static ISprite CreateSmallRightRunningSprite()
        {
            return new SmallRightRunningSprite(marioSpriteSheet);
        }
    }
}
