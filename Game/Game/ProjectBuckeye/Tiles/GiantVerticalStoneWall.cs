using Game.Interfaces;
using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities;

namespace Game.ProjectBuckeye.Tiles
{
    public class GiantVerticalStoneWall : IBuckeyeTile
    {
        private ISprite sprite;
        private Game1 myGame;
        private Vector2 location;

        public GiantVerticalStoneWall(Game1 game)
        {
            myGame = game;
            sprite = BuckeyeTileSpriteFactory.CreateStoneWallTile();
        }

        public void Update()
        {
            sprite.Update();
        }

        public void Draw(ICamera camera)
        {
            sprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return sprite; }
            set { sprite = value; }
        }

        public IPhysics Physics
        {
            get { return null; }
        }
    }
}
