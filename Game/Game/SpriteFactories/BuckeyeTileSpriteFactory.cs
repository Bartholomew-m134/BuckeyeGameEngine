using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Game.Interfaces;
using Game.Utilities.Constants;
using Game.ProjectBuckeye.Tiles.TileSprites;

namespace Game.SpriteFactories
{
    public static class BuckeyeTileSpriteFactory
    {
        private static Texture2D tileSheet;

        public static void Load(ContentManager content)
        {
            tileSheet = content.Load<Texture2D>(SpriteFactoryConstants.PROJECTBUCKEYETILESHEET);
        }

        public static void Unload()
        {

        }

        public static ISprite CreateGrassTile()
        {
            return new GrassTileSprite(tileSheet);
        }

        public static ISprite CreateGroundTile()
        {
            return new GroundTileSprite(tileSheet);
        }

        public static ISprite CreateStoneTile()
        {
            return new StoneTileSprite(tileSheet);
        }
    }
}
