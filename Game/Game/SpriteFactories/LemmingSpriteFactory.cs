using Game.Interfaces;
using Game.Items.ItemSprites;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;

namespace Game.SpriteFactories
{
    class LemmingSpriteFactory
    {

        private static Texture2D elevatorSpriteSheet;

        public static void Load(ContentManager content)
        {
            elevatorSpriteSheet = content.Load<Texture2D>(SpriteFactoryConstants.ELEVATORSPRITESHEET);

        }

        public static void Unload()
        {

        }

        public static ISprite CreateElevatorSprite()
        {
            return new RedMushroomSprite(elevatorSpriteSheet);
        }
    }
}
