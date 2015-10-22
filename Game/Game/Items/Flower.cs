﻿using Game.Interfaces;
using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities;

namespace Game.Items
{
    public class Flower : IItem
    {
        private Game1 myGame;
        private ISprite flowerSprite;
        private Vector2 location;
        private ObjectPhysics physics;

        public Flower(Game1 game)
        {
            myGame = game;
            flowerSprite = ItemsSpriteFactory.CreateFlowerSprite();
            physics = new ObjectPhysics;
        }

        public void Update()
        {
            flowerSprite.Update();
        }

        public void Draw() {
            flowerSprite.Draw(myGame.spriteBatch, location);
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
            get { return flowerSprite; }
            set { flowerSprite = value; }
        }

        public ObjectPhysics Physics
        {
            get { return physics; }
        }

    }

}
