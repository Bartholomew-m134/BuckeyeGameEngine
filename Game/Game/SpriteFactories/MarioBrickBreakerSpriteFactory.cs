using Game.Interfaces;
using Game.ProjectMarioBrickBreaker.PaddleBallClasses.PaddleBallSprites;
using Game.ProjectMarioBrickBreaker.PlayerClasses.PaddleSprites;
using Game.ProjectPacMario.PlayerClasses.PlayerSprites;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.SpriteFactories
{
    public static class MarioBrickBreakerSpriteFactory
    {
        private static Texture2D itemsSpriteSheet;
        private static Texture2D scenerySpriteSheet;
        private static Texture2D enemySpriteSheet;

        public static void Load(ContentManager content)
        {
            itemsSpriteSheet = content.Load<Texture2D>(SpriteFactoryConstants.ITEMSPRITESHEET);
            scenerySpriteSheet = content.Load<Texture2D>(SpriteFactoryConstants.SCENERYSPRITESHEET);
            enemySpriteSheet = content.Load<Texture2D>(SpriteFactoryConstants.ENEMYSPRITESHEET);
        }

        public static void Unload()
        {

        }

        public static ISprite CreateNormalPaddleSprite() {
            return new NormalPaddleSprite(itemsSpriteSheet);
        }

        public static ISprite CreateMushroomPaddleSprite()
        {
            return new MushroomPaddleSprite(scenerySpriteSheet);
        }

        public static ISprite CreateNormalPaddleBallSprite()
        {
            return new NormalPaddleBallSprite(enemySpriteSheet);
        }

        public static ISprite CreateSuperPaddleBallSprite()
        {
            return new SuperPaddleBallSprite(enemySpriteSheet);
        }
    }
}
