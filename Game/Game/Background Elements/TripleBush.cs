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
    class TripleBush:IGameObject
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
       
        public void Draw() {
            
                tripleBushSprite.Draw(myGame.spriteBatch, location);
            
        }


        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite GetSetSprite
        {
            get { return tripleBushSprite; }
            set { tripleBushSprite = value; }
        }

        public ObjectPhysics Physics
        {
            get { return null; }
        }
    }
}
