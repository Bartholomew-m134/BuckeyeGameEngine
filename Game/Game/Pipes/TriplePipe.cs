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
    public class TriplePipe : IPipe
    {
        private Game1 myGame;
        private ISprite pipeSprite;
        private Vector2 location;
        private Vector2 warpLocation;
        private bool isWarpPipe;
        private IGameState gameState;
        
        public TriplePipe(Game1 game)
        {
            myGame = game;
            pipeSprite = TileSpriteFactory.CreateTriplePipeSprite();
            isWarpPipe = false;
        }

        public TriplePipe(Vector2 marioWarpCoordinates, Game1 game)
        {
            myGame = game;
            pipeSprite = TileSpriteFactory.CreateTriplePipeSprite();
            isWarpPipe = true;
            warpLocation = marioWarpCoordinates;
        }

        public TriplePipe(IGameState gameState, Game1 game)
        {
            myGame = game;
            pipeSprite = TileSpriteFactory.CreateTriplePipeSprite();
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

        public IPhysics Physics
        {
            get { return null; }
        }
    }


}