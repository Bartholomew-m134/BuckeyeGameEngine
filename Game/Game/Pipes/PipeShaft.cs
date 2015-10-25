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
    public class PipeShaft : IPipe
    {
        private Game1 myGame;
        private ISprite pipeSprite;
        private Vector2 location;

        public PipeShaft(Game1 game)
        {
            myGame = game;
            pipeSprite = TileSpriteFactory.CreatePipeShaftSprite();

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

        public ISprite Sprite
        {
            get { return pipeSprite; }
            set { pipeSprite = value; }
        }

        public ObjectPhysics Physics
        {
            get { return null; }
        }
    }


}