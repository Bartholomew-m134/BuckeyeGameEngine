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
    public class StarSprite : ISprite
    {
        private Texture2D Texture { get; set; }
        private int currentFrame;
        private int sourceX;
        public StarSprite(Texture2D texture)
        {
            Texture = texture;
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame == ItemSpriteConstants.TOTALSTARFRAMES)
            {
                currentFrame = ItemSpriteConstants.RESETTOZERO;
            }
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location) {
            sourceX = (int)ItemSpriteConstants.STARSOURCE.X + ItemSpriteConstants.DISTANCEBETWEENSTARSPRITES * currentFrame;    
            Rectangle sourceRectangle = new Rectangle(sourceX, (int)ItemSpriteConstants.STARSOURCE.Y,
                (int)ItemSpriteConstants.STARDIMENSIONS.X, (int)ItemSpriteConstants.STARDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)ItemSpriteConstants.STARDIMENSIONS.X, (int)ItemSpriteConstants.STARDIMENSIONS.Y);
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)ItemSpriteConstants.STARDIMENSIONS.X, (int)ItemSpriteConstants.STARDIMENSIONS.Y); }
        }
    }
}
