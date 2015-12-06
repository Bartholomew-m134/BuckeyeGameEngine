using Game.Interfaces;
using Game.Lemming;
using Game.Lemming.Elevators;
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

        private static Texture2D endblockSpriteSheet;

        public static void Load(ContentManager content)
        {
            elevatorSpriteSheet = content.Load<Texture2D>(SpriteFactoryConstants.ELEVATORSPRITESHEET);
            endblockSpriteSheet = content.Load<Texture2D>(SpriteFactoryConstants.ENDBLOCKSPRITESHEET);
        }


        public static void Unload()
        {

        }

        public static ISprite CreateElevatorSprite()
        {
            return new ElevatorSprite(elevatorSpriteSheet);
        }

        public static ISprite CreateEndblockSprite()
        {
            return new EndblockSprite(endblockSpriteSheet);
        }
    }
}
