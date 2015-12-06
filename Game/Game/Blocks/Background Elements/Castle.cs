using Game.Interfaces;
using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities;

namespace Game.Background_Elements
{
    class Castle : IScenery
    {

        private Game1 myGame;
        private ISprite castleSprite;
        private Vector2 location;

        public Castle(Game1 game)
        {
            myGame = game;
            castleSprite = BackgroundElementsSpriteFactory.CreateCastleSprite();

        }

        public void Update()
        {
            castleSprite.Update();
        }

        public void Draw(ICamera camera)
        {
            castleSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }


        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return castleSprite; }
            set { castleSprite = value; }
        }

        public IPhysics Physics
        {
            get { return null; }
        }
    }
}