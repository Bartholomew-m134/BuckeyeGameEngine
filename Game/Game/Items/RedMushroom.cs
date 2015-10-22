﻿using Game.Interfaces;
using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Items
{
    public class RedMushroom : IItem
    {
        private Game1 myGame;
        private ISprite redMushroomSprite;
        private Vector2 location;

        public RedMushroom(Game1 game)
        {
            myGame = game;
            redMushroomSprite = ItemsSpriteFactory.CreateRedMushroomSprite();
        }

        public void Update()
        {
            redMushroomSprite.Update();
        }

        public void Draw(ICamera camera)
        {
            redMushroomSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public void Disappear() {
            location.Y -= 2000;
        }
        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite GetSetSprite
        {
            get { return redMushroomSprite; }
            set { redMushroomSprite = value; }
        }

    }
}
