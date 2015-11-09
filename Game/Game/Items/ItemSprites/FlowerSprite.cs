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
    public class FlowerSprite : ISprite
    {
        private Texture2D Texture { get; set; }
        private int currentFrame;
        private int sourceX;
        public FlowerSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == ItemSpriteConstants.TOTALFLOWERFRAMES)
                currentFrame = ItemSpriteConstants.RESETTOZERO;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location) 
        {
            sourceX = (int)ItemSpriteConstants.FLOWERSOURCE.X + ItemSpriteConstants.DISTANCEBETWEENFLOWERSPRITES * currentFrame;
            
            Rectangle sourceRectangle = new Rectangle(sourceX, (int)ItemSpriteConstants.FLOWERSOURCE.Y,
                (int)ItemSpriteConstants.FLOWERDIMENSIONS.X, (int)ItemSpriteConstants.FLOWERDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)ItemSpriteConstants.FLOWERDIMENSIONS.X, (int)ItemSpriteConstants.FLOWERDIMENSIONS.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)ItemSpriteConstants.FLOWERDIMENSIONS.X, (int)ItemSpriteConstants.FLOWERDIMENSIONS.Y); }
        }

    }
}
