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
    class TripleBush : IScenery
    {

        private Game1 myGame;
        private ISprite tripleBushSprite;
        private Vector2 location;


        public TripleBush(Game1 game)
        {
            myGame = game;
            tripleBushSprite = BackgroundElementsSpriteFactory.CreateTripleBushSprite();

        }

        public void Update()
        {
            tripleBushSprite.Update();
        }

        public void Draw(ICamera camera)
        {
            tripleBushSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }


        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return tripleBushSprite; }
            set { tripleBushSprite = value; }
        }

        public IPhysics Physics
        {
            get { return null; }
        }
    }
}
