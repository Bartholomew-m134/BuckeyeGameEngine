using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Game.Interfaces;
using Game.Utilities.Constants;
using Game.ProjectBuckeye.PlayerClasses.BuckeyePlayerSprites;

namespace Game.SpriteFactories
{
    public static class BuckeyePlayerSpriteFactory
    {
        private static Texture2D buckeyeSpriteSheet;

        public static void Load(ContentManager content)
        {
            buckeyeSpriteSheet = content.Load<Texture2D>(SpriteFactoryConstants.BUCKEYEPLAYERSPRITESHEET);
        }

        public static void Unload()
        {

        }

        public static ISprite CreateBuckeyeLeftDownSprite()
        {
            return new BuckeyeLeftDownSprite(buckeyeSpriteSheet);
        }

        public static ISprite CreateBuckeyeLeftIdleSprite()
        {
            return new BuckeyeLeftIdleSprite(buckeyeSpriteSheet);
        }

        public static ISprite CreateBuckeyeLeftJumpingSprite()
        {
            return new BuckeyeLeftJumpingSprite(buckeyeSpriteSheet);
        }

        public static ISprite CreateBuckeyeLeftMovementSprite()
        {
            return new BuckeyeLeftMovementSprite(buckeyeSpriteSheet);
        }

        public static ISprite CreateBuckeyeRightDownSprite()
        {
            return new BuckeyeRightDownSprite(buckeyeSpriteSheet);
        }

        public static ISprite CreateBuckeyeRightIdleSprite()
        {
            return new BuckeyeRightIdleSprite(buckeyeSpriteSheet);
        }

        public static ISprite CreateBuckeyeRightJumpingSprite()
        {
            return new BuckeyeRightJumpingSprite(buckeyeSpriteSheet);
        }

        public static ISprite CreateBuckeyeRightMovementSprite()
        {
            return new BuckeyeRightMovementSprite(buckeyeSpriteSheet);
        }
    }
}
