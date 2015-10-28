using Game.Interfaces;
using Game.Projectiles.ProjectileSprites;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.SpriteFactories
{
    class ProjectileSpriteFactory
    {

        private static Texture2D enemiesSpriteSheet;

        public static void Load(ContentManager content)
        {
            enemiesSpriteSheet = content.Load<Texture2D>("EnemiesSpriteSheet");

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
    }
}
