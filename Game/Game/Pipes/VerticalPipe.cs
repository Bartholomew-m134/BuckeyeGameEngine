﻿using Game.Interfaces;
using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities;

namespace Game.Pipes
{
    public class VerticalPipe : IPipe
    {
        private Game1 myGame;
        private ISprite pipeSprite;
        private Vector2 location;
        private bool isWarpPipe;

        public VerticalPipe(Game1 game)
        {
            myGame = game;
            pipeSprite = TileSpriteFactory.CreateSidePipeSprite();
            isWarpPipe = false;
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

        public Vector2 WarpVectorCoordinates
        {
            get { return Vector2.Zero; }

        }

        public ISprite Sprite
        {
            get { return pipeSprite; }
            set { pipeSprite = value; }
        }

        public bool IsWarpPipe
        {
            get { return isWarpPipe; }

        }


        public bool IsGameStatePipe
        {
            get { return false; }
        }

        public IGameState GameState
        {
            get { return null; }
        }

        public IPhysics Physics
        {
            get { return null; }
        }
    }


}