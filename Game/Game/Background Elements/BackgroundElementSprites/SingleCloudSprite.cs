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
    class SingleCloudSprite:ISprite
    {
        private Texture2D Texture { get; set; }
        public SingleCloudSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update() { 
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location) {
            Rectangle sourceRectangle = new Rectangle((int)BackgroundElementSpriteConstants.SINGLCLOUDSOURCE.X, (int)BackgroundElementSpriteConstants.SINGLCLOUDSOURCE.Y,
                (int)BackgroundElementSpriteConstants.SINGLECLOUDDIMENSIONS.X, (int)BackgroundElementSpriteConstants.SINGLECLOUDDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)BackgroundElementSpriteConstants.SINGLECLOUDDIMENSIONS.X, (int)BackgroundElementSpriteConstants.SINGLECLOUDDIMENSIONS.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)BackgroundElementSpriteConstants.SINGLECLOUDDIMENSIONS.X, (int)BackgroundElementSpriteConstants.SINGLECLOUDDIMENSIONS.Y); }
        }
    }
}
