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
    class TripleBushSprite:ISprite
    {
        private Texture2D Texture { get; set; }
        public TripleBushSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update() { 
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location) {
            Rectangle sourceRectangle = new Rectangle((int)BackgroundElementSpriteConstants.TRIPLEBUSHSOURCE.X, (int)BackgroundElementSpriteConstants.TRIPLEBUSHSOURCE.Y,
                (int)BackgroundElementSpriteConstants.TRIPLEBUSHDIMENSIONS.X, (int)BackgroundElementSpriteConstants.TRIPLEBUSHDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)BackgroundElementSpriteConstants.TRIPLEBUSHDIMENSIONS.X, (int)BackgroundElementSpriteConstants.TRIPLEBUSHDIMENSIONS.Y);
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)BackgroundElementSpriteConstants.TRIPLEBUSHDIMENSIONS.X, (int)BackgroundElementSpriteConstants.TRIPLEBUSHDIMENSIONS.Y); }
        }
    }
}
