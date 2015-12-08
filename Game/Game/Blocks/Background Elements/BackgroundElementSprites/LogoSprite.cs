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
    public class LogoSprite : ISprite
    {
        private Texture2D Texture;
        private Rectangle sourceRectangle = new Rectangle((int)BackgroundElementSpriteConstants.LOGOSOURCE.X, (int)BackgroundElementSpriteConstants.LOGOSOURCE.Y,
            (int)BackgroundElementSpriteConstants.LOGODIMENSIONS.X, (int)BackgroundElementSpriteConstants.LOGODIMENSIONS.Y);

        public LogoSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update() { 
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location) {
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 
                (int)BackgroundElementSpriteConstants.LOGODIMENSIONS.X, (int)BackgroundElementSpriteConstants.LOGODIMENSIONS.Y);

            //float scale = .8f;
            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            //spriteBatch.Draw(Texture, location, null,Color.White, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)BackgroundElementSpriteConstants.LOGODIMENSIONS.X, (int)BackgroundElementSpriteConstants.LOGODIMENSIONS.Y); }
        }
    }
}
