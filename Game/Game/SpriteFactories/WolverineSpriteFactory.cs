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

namespace Game.SpriteFactories
{
    public static class WolverineSpriteFactory
    {
        private static Texture2D wolverineSpriteSheet;

        public static void Load(ContentManager content)
        {
            wolverineSpriteSheet = content.Load<Texture2D>(SpriteFactoryConstants.WOLVERINEPLAYERSPRITESHEET);
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

        public static ISprite CreateWolverineRightDownSprite()
        {
            return new WolverineDownRightSprite(wolverineSpriteSheet);
        }
    }
}
