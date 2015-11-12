using Game.Interfaces;
using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities;

namespace Game.Pipes
{
    public class FullSidePipe : IPipe
    {
        private Game1 myGame;
        private ISprite pipeSprite;
        private Vector2 location;
        private Vector2 warpLocation;
        private bool isWarpPipe;
        private bool isSideWarpPipe;
        public FullSidePipe(Game1 game)
        {
            myGame = game;
            pipeSprite = TileSpriteFactory.CreateFullSidePipeSprite();
            isWarpPipe = false;
            isSideWarpPipe = false;
        }

        public FullSidePipe(Vector2 marioWarpCoordinates, Game1 game)
        {
            myGame = game;
            pipeSprite = TileSpriteFactory.CreateFullSidePipeSprite();
            isWarpPipe = true;
            isSideWarpPipe = true;
            warpLocation = marioWarpCoordinates;
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
            get { return warpLocation; }

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

        public bool IsSideWarpPipe
        {
            get { return isSideWarpPipe; }

        }

        public ObjectPhysics Physics
        {
            get { return null; }
        }
    }


}

