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
    class SmallHillSprite:ISprite
    {
        private Texture2D Texture { get; set; }
        public SmallHillSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update() { 
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location) {
            Rectangle sourceRectangle = new Rectangle((int)BackgroundElementSpriteConstants.SMALLHILLSOURCE.X, (int)BackgroundElementSpriteConstants.SMALLHILLSOURCE.Y,
                (int)BackgroundElementSpriteConstants.SMALLHILLDIMENSIONS.X, (int)BackgroundElementSpriteConstants.SMALLHILLDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)BackgroundElementSpriteConstants.SMALLHILLDIMENSIONS.X, (int)BackgroundElementSpriteConstants.SMALLHILLDIMENSIONS.Y);
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)BackgroundElementSpriteConstants.SMALLHILLDIMENSIONS.X, (int)BackgroundElementSpriteConstants.SMALLHILLDIMENSIONS.Y); }
        }
    }
}
