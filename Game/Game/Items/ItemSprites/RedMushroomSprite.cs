using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities.Constants;
namespace Game.Items.ItemSprites
{
    public class RedMushroomSprite : ISprite
    {
        private Texture2D Texture { get; set; }
        public RedMushroomSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update() 
        { 
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location) 
        {
            Rectangle sourceRectangle = new Rectangle((int)ItemSpriteConstants.REDMUSHSOURCE.X, (int)ItemSpriteConstants.REDMUSHSOURCE.Y,
                (int)ItemSpriteConstants.REDMUSHDIMENSIONS.X, (int)ItemSpriteConstants.REDMUSHDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)ItemSpriteConstants.REDMUSHDIMENSIONS.X, (int)ItemSpriteConstants.REDMUSHDIMENSIONS.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)ItemSpriteConstants.REDMUSHDIMENSIONS.X, (int)ItemSpriteConstants.REDMUSHDIMENSIONS.Y); }
        }
    }
}
