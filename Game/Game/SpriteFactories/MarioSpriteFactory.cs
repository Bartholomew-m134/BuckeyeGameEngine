using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Game.Mario.MarioSprites;
using Game.Interfaces;

namespace Game.SpriteFactories
{
    public static class MarioSpriteFactory
    {
        private static Texture2D marioSpriteSheet;

        public static void Load(ContentManager content)
        {
            marioSpriteSheet = content.Load<Texture2D>("MarioSpriteSheet");

        }

        public static void Unload()
        {

        }

        public static ISprite CreateDeadSprite()
        {
            return new DeadMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireLeftCrouchingSprite()
        {
            return new FireLeftCrouchingMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireLeftIdleSprite()
        {
            return new FireLeftIdleMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireLeftJumpingSprite()
        {
            return new FireLeftJumpingMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireLeftRunningSprite()
        {
            return new FireLeftRunningMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireLeftTwistSprite()
        {
            return new FireLeftTwistSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireRightCrouchingSprite()
        {
            return new FireRightCrouchingMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireRightIdleSprite()
        {
            return new FireRightIdleMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireRightJumpingSprite()
        {
            return new FireRightJumpingMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireRightRunningSprite()
        {
            return new FireRightRunningMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateFireRightTwistSprite()
        {
            return new FireRightTwistSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalLeftCrouchingSprite()
        {
            return new NormalLeftCrouchingMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalLeftIdleSprite()
        {
            return new NormalLeftIdleMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalLeftJumpingSprite()
        {
            return new NormalLeftJumpingMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalLeftRunningSprite()
        {
            return new NormalLeftRunningMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalLeftTwistSprite()
        {
            return new NormalLeftTwistSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalRightCrouchingSprite()
        {
            return new NormalRightCrouchingMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalRightIdleSprite()
        {
            return new NormalRightIdleMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalRightJumpingSprite()
        {
            return new NormalRightJumpingMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalRightRunningSprite()
        {
            return new NormalRightRunningMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalRightTwistSprite()
        {
            return new NormalRightTwistSprite(marioSpriteSheet);
        }

        public static ISprite CreateSmallLeftIdleSprite()
        {
            return new SmallLeftIdleMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateSmallLeftJumpingSprite()
        {
            return new SmallLeftJumpingMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateSmallLeftRunningSprite()
        {
            return new SmallLeftRunningMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateSmallLeftTwistSprite()
        {
            return new SmallLeftTwistSprite(marioSpriteSheet);
        }

        public static ISprite CreateSmallRightIdleSprite()
        {
            return new SmallRightIdleMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateSmallRightJumpingSprite()
        {
            return new SmallRightJumpingMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateSmallRightRunningSprite()
        {
            return new SmallRightRunningMarioSprite(marioSpriteSheet);
        }

        public static ISprite CreateSmallRightTwistSprite()
        {
            return new SmallRightTwistSprite(marioSpriteSheet);
        }

        public static ISprite CreateNormalFlagPoleSlidingSprite()
        {
            return new NormalFlagPoleSlidingSprite(marioSpriteSheet);
        }
        public static ISprite CreateFireFlagPoleSlidingSprite()
        {
            return new FireFlagPoleSlidingSprite(marioSpriteSheet);
        }
        public static ISprite CreateSmallFlagPoleSlidingSprite()
        {
            return new SmallFlagPoleSlidingSprite(marioSpriteSheet);
        }
    }
}
