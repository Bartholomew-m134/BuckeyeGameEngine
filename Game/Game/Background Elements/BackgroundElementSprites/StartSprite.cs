using Game.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;

namespace Game.Background_Elements.BackgroundElementSprites
{
    class StartSprite : ISprite
    {
        private Texture2D Texture;
        public StartSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)BackgroundElementSpriteConstants.STARTSOURCE.X, (int)BackgroundElementSpriteConstants.STARTSOURCE.Y,
                (int)BackgroundElementSpriteConstants.STARTDIMENSIONS.X, (int)BackgroundElementSpriteConstants.STARTDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)BackgroundElementSpriteConstants.STARTDIMENSIONS.X, (int)BackgroundElementSpriteConstants.STARTDIMENSIONS.Y);
            //float scale = .9f;
            spriteBatch.Begin();
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