using Game.Interfaces;
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

        public static void Load(ContentManager content)
        {
            pacMarioSpriteSheet = content.Load<Texture2D>(SpriteFactoryConstants.PACMARIOSPRITESHEET);
        }

        public static void Unload()
        {

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
    }
}
