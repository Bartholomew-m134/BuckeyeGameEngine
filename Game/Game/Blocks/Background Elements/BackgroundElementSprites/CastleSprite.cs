using Game.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;
using Game.Utilities;

namespace Game.Background_Elements.BackgroundElementSprites
{
    class CastleSprite : ISprite
    {
        private Texture2D Texture { get; set; }
        private Rectangle sourceRectangle = new Rectangle((int)BackgroundElementSpriteConstants.CASTLESOURCE.X, (int)BackgroundElementSpriteConstants.CASTLESOURCE.Y,
            (int)BackgroundElementSpriteConstants.CASTLEDIMENSIONS.X, (int)BackgroundElementSpriteConstants.CASTLEDIMENSIONS.Y);

        public CastleSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)BackgroundElementSpriteConstants.CASTLEDIMENSIONS.X, (int)BackgroundElementSpriteConstants.CASTLEDIMENSIONS.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)BackgroundElementSpriteConstants.CASTLEDIMENSIONS.X, (int)BackgroundElementSpriteConstants.CASTLEDIMENSIONS.Y); }
        }
    }
}
