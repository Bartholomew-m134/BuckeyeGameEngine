﻿using Game.Interfaces;
using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities;

namespace Game.Background_Elements
{
    class SingleBush : IScenery
    {

        private Game1 myGame;
        private ISprite singleBushSprite;
        private Vector2 location;

        public SingleBush(Game1 game)
        {
            myGame = game;
            singleBushSprite = BackgroundElementsSpriteFactory.CreateSingleBushSprite();
        }

        public void Update()
        {
            singleBushSprite.Update();
        }

        public void Draw(ICamera camera)
        {
            singleBushSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return singleBushSprite; }
            set { singleBushSprite = value; }
        }

        public IPhysics Physics
        {
            get { return null; }
        }
    }
  }

