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
    class StartSprite : ISprite
    {
        private Texture2D Texture;
        private Rectangle sourceRectangle = new Rectangle((int)BackgroundElementSpriteConstants.STARTSOURCE.X, (int)BackgroundElementSpriteConstants.STARTSOURCE.Y,
            (int)BackgroundElementSpriteConstants.STARTDIMENSIONS.X, (int)BackgroundElementSpriteConstants.STARTDIMENSIONS.Y);

        public StartSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)BackgroundElementSpriteConstants.STARTDIMENSIONS.X, (int)BackgroundElementSpriteConstants.STARTDIMENSIONS.Y);

            //float scale = .9f;
            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            //spriteBatch.Draw(Texture, location, null, Color.White, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)BackgroundElementSpriteConstants.STARTDIMENSIONS.X, (int)BackgroundElementSpriteConstants.STARTDIMENSIONS.Y); }
        }
    }
}