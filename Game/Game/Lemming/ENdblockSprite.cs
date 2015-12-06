using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities.Constants;
using Game.Utilities;

namespace Game.Lemming
{
    class EndblockSprite : ISprite
    {
        private Texture2D Texture { get; set; }

        public EndblockSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)LemmingSpriteConstants.ENDBLOCKSOURCE.X, (int)LemmingSpriteConstants.ENDBLOCKSOURCE.Y,
                (int)LemmingSpriteConstants.ENDBLOCKDIMENSIONS.X, (int)LemmingSpriteConstants.ENDBLOCKDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)LemmingSpriteConstants.ENDBLOCKDIMENSIONS.X, (int)LemmingSpriteConstants.ENDBLOCKDIMENSIONS.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)LemmingSpriteConstants.ENDBLOCKDIMENSIONS.X, (int)LemmingSpriteConstants.ENDBLOCKDIMENSIONS.Y); }
        }
    }
}