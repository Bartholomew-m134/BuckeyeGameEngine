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
    public class DoublePipe : IPipe
    {
        private Game1 myGame;
        private ISprite pipeSprite;
        private Vector2 location;
        private Vector2 warpLocation;
        private bool isWarpPipe;
        private IGameState gameState;

        public DoublePipe(Game1 game)
        {
            myGame = game;
            pipeSprite = TileSpriteFactory.CreateDoublePipeSprite();
            isWarpPipe = false;
        }

        public DoublePipe(Vector2 marioWarpCoordinates, Game1 game)
        {
            myGame = game;
            pipeSprite = TileSpriteFactory.CreateDoublePipeSprite();
            isWarpPipe = true;
            warpLocation = marioWarpCoordinates;
        }

        public DoublePipe(IGameState gameState, Game1 game)
        {
            myGame = game;
            pipeSprite = TileSpriteFactory.CreateDoublePipeSprite();
            isWarpPipe = true;
            this.gameState = gameState;
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

        public bool IsGameStatePipe
        {
            get { return gameState != null; }
        }

        public IGameState GameState
        {
            get { return gameState; }
        }

        public ObjectPhysics Physics
        {
            get { return null; }
        }
    }


}