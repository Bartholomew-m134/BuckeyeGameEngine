using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Game.Interfaces;
using Game.Utilities.Constants;
using Game.ProjectBuckeye.EnemyClasses.WolverineSprites;
using Game.ProjectBuckeye.EnemyClasses.WolverineChuckSprites;

namespace Game.SpriteFactories
{
    public static class WolverineSpriteFactory
    {
        private static Texture2D wolverineSpriteSheet;
        private static Texture2D chuckSpriteSheet;

        public static void Load(ContentManager content)
        {
            wolverineSpriteSheet = content.Load<Texture2D>(SpriteFactoryConstants.WOLVERINEPLAYERSPRITESHEET);
            chuckSpriteSheet = content.Load<Texture2D>(SpriteFactoryConstants.WOLVERINECHUCKSPRITESHEET);
        }
        public static ISprite CreateWolverineRightMovingSprite()
        {
            return new WolverineMovingRightSprite(wolverineSpriteSheet);
        }

        public static ISprite CreateWolverineLeftMovingSprite()
        {
            return new WolverineMovingLeftSprite(wolverineSpriteSheet);
        }

        public static ISprite CreateWolverineLeftDownSprite()
        {
            return new WolverineDownLeftSprite(wolverineSpriteSheet);
        }

        public static ISprite CreateWolverineLeftIdleSprite()
        {
            return new WolverineLeftIdleSprite(wolverineSpriteSheet);
        }

        public static ISprite CreateWolverineRightDownSprite()
        {
            return new WolverineDownRightSprite(wolverineSpriteSheet);
        }

        public static ISprite CreateWolverineChuckCharginLeftSprite()
        {
            return new WolverineChuckCharginLeftSprite(chuckSpriteSheet);
        }

        public static ISprite CreateWolverineChuckCharginRightSprite()
        {
            return new WolverineChuckCharginRightSprite(chuckSpriteSheet);
        }

        public static ISprite CreateWolverineChuckIdleRightSprite()
        {
            return new WolverineChuckIdleRightSprite(chuckSpriteSheet);
        }

        public static ISprite CreateWolverineChuckIdleLeftSprite()
        {
            return new WolverineChuckIdleLeftSprite(chuckSpriteSheet);
        }
    }
}
