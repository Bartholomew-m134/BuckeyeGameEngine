using Game.Interfaces;
using Game.Projectiles.ProjectileSprites;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;
using Game.ProjectBuckeye.FootballClasses;

namespace Game.SpriteFactories
{
    public static class ProjectileSpriteFactory
    {

        private static Texture2D enemiesSpriteSheet;
        private static Texture2D footBallSprite;

        public static void Load(ContentManager content)
        {
            enemiesSpriteSheet = content.Load<Texture2D>(SpriteFactoryConstants.ENEMYSPRITESHEET);
            footBallSprite = content.Load<Texture2D>(SpriteFactoryConstants.FOOTBALLSPRITE);
        }

        public static void Unload()
        {

        }

        public static ISprite CreateFireSprite()
        {
            return new FireSprite(enemiesSpriteSheet);
        }

        public static ISprite CreateExplodingFireSprite()
        {
            return new ExplodingFireSprite(enemiesSpriteSheet);
        }

        public static ISprite CreateFootballSprite()
        {
            return new FootballSprite(footBallSprite);
        }
    }
}
