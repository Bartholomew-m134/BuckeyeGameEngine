using Game.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;
using Game.Utilities;

namespace Game.ProjectBuckeye.Tiles.TileSprites
{
    public class GrassTileSprite : ISprite
    {
        private Texture2D texture;
        private const int xLocation = 24;
        private const int yLocation = 5;
        private const int xDimension = 16;
        private const int yDimension = 16;
        private Rectangle sourceRectangle = new Rectangle(xLocation, yLocation, xDimension, yDimension);

        public GrassTileSprite(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Update()
        {
        }

        public void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch, Microsoft.Xna.Framework.Vector2 location)
        {
            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(texture, location, sourceRectangle, Color.White, 0f, Vector2.Zero, 1, SpriteEffects.None, 0f);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2(xDimension, yDimension); }
        }
    }
}
