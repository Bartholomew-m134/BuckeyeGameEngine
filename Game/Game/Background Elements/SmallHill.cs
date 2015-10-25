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
    class SmallHill : IScenery
    {
        private Game1 myGame;
        private ISprite smallHillSprite;
        private Vector2 location;


        public SmallHill(Game1 game)
        {
            myGame = game;
            smallHillSprite = BackgroundElementsSpriteFactory.CreateSmallHillSprite();

        }

        public void Update()
        {
            smallHillSprite.Update();
        }

        public void Draw(ICamera camera)
        {
            smallHillSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }


        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return smallHillSprite; }
            set { smallHillSprite = value; }
        }

        public ObjectPhysics Physics
        {
            get { return null; }
        }
    }
 }

