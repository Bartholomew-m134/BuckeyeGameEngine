﻿using Game.Interfaces;
using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Pipes
{
    public class Pipe : IPipe
    {
        private Game1 myGame;
        private ISprite pipeSprite;
        private Vector2 location;

        public Pipe(Game1 game)
        {
            myGame = game;
            pipeSprite = TileSpriteFactory.CreatePipeSprite();

        }

        public void Update()
        {
            pipeSprite.Update();
        }

        public void Draw(ICamera camera)
        {
            pipeSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite GetSetSprite
        {
            get { return pipeSprite; }
            set { pipeSprite = value; }
        }
    }


}
