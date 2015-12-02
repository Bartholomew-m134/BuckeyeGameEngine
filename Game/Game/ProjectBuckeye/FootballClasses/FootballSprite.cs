using Game.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;
using Game.Utilities;

namespace Game.ProjectBuckeye.FootballClasses
{
    public class FootballSprite : ISprite
    {
        private Texture2D texture;
        private const int xLocation = 0;
        private const int yLocation = 3;
        private const int xDimension = 20;
        private const int yDimension = 14;
        private Rectangle sourceRectangle = new Rectangle(xLocation, yLocation, xDimension, yDimension);

        public FootballSprite(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Update()
        {
        }

        public void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch, Microsoft.Xna.Framework.Vector2 location)
        {
            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            spriteBatch.Draw(texture, location, sourceRectangle, Color.White, 0f, Vector2.Zero, 1, SpriteEffects.None, 0f);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2(xDimension, yDimension); }
        }
    }
}
