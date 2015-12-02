using Game.Interfaces;
using Game.ProjectPacMario.EnemyClasses.EnemySprites;
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
    public static class PacMarioSpriteFactory
    {
        private static Texture2D pacMarioSpriteSheet;
        private static Texture2D pacMarioEnemySpriteSheet;
        private static Texture2D enemySpriteSheet;

        public static void Load(ContentManager content)
        {
            pacMarioSpriteSheet = content.Load<Texture2D>(SpriteFactoryConstants.PACMARIOSPRITESHEET);
            pacMarioEnemySpriteSheet = content.Load<Texture2D>(SpriteFactoryConstants.PACMARIOENEMYSPRITESHEET);
            enemySpriteSheet = content.Load<Texture2D>(SpriteFactoryConstants.ENEMYSPRITESHEET);
        }

        public static void Unload()
        {

        }
        public static ISprite CreateDeadPacMarioSprite()
        {
            return new PacMarioDeadSprite(enemySpriteSheet);
        }
        public static ISprite CreateLeftPacMarioSprite()
        {
            return new PacMarioLeftSprite(pacMarioSpriteSheet);
        }

        public static ISprite CreateRightPacMarioSprite()
        {
            return new PacMarioRightSprite(pacMarioSpriteSheet);
        }

        public static ISprite CreateUpPacMarioSprite()
        {
            return new PacMarioUpSprite(pacMarioSpriteSheet);
        }

        public static ISprite CreateDownPacMarioSprite()
        {
            return new PacMarioDownSprite(pacMarioSpriteSheet);
        }

        public static ISprite CreateDownBooSprite()
        {
            return new DownPatrolingBooSprite(pacMarioEnemySpriteSheet);
        }
        public static ISprite CreateUpBooSprite()
        {
            return new UpPatrolingBooSprite(pacMarioEnemySpriteSheet);
        }
        public static ISprite CreateLeftBooSprite()
        {
            return new LeftPatrolingBooSprite(pacMarioEnemySpriteSheet);
        }
        public static ISprite CreateRightBooSprite()
        {
            return new RightPatrolingBooSprite(pacMarioEnemySpriteSheet);
        }
        public static ISprite CreateDeadBooSprite()
        {
            return new DeadBooSprite(enemySpriteSheet);
        }
    }
}
