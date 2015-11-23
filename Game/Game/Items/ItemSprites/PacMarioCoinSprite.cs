﻿using System;
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
    public class PacMarioCoinSprite : ISprite
    {
        private Texture2D texture;
        private int currentFrame;
        private int sourceX;
        public PacMarioCoinSprite(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Update() {
            currentFrame++;
            if (currentFrame == ItemSpriteConstants.TOTALCOINFRAMES)
                currentFrame = ItemSpriteConstants.RESETTOZERO;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location) {
            sourceX = (int)ItemSpriteConstants.COINSOURCE.X + ItemSpriteConstants.DISTANCEBETWEENCOINSPRITES * currentFrame;
            Rectangle sourceRectangle = new Rectangle(sourceX, (int)ItemSpriteConstants.COINSOURCE.Y,
                (int)ItemSpriteConstants.COINDIMENSIONS.X, (int)ItemSpriteConstants.COINDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)ItemSpriteConstants.COINDIMENSIONS.X, (int)ItemSpriteConstants.COINDIMENSIONS.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.Red);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)ItemSpriteConstants.COINDIMENSIONS.X, (int)ItemSpriteConstants.COINDIMENSIONS.Y); }
        }

    }
}
