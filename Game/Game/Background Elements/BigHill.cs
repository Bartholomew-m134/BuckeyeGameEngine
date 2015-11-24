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
    class BigHill : IScenery
    {

        private Game1 myGame;
        private ISprite bigHillSprite;
        private Vector2 location;

        public BigHill(Game1 game)
        {
            myGame = game;
            bigHillSprite = BackgroundElementsSpriteFactory.CreateBigHillSprite();

        }

        public void Update()
        {
            bigHillSprite.Update();
        }

        public void Draw(ICamera camera)
        {
            bigHillSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }


        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return bigHillSprite; }
            set { bigHillSprite = value; }
        }

        public IPhysics Physics
        {
            get { return null; }
        }
    }
}
