﻿using Game.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;

namespace Game.Background_Elements.BackgroundElementSprites
{
    class SingleBushSprite:ISprite
    {
        private Texture2D Texture { get; set; }
        public SingleBushSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update() { 
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location) {
            Rectangle sourceRectangle = new Rectangle((int)BackgroundElementSpriteConstants.SINGLEBUSHSOURCE.X, (int)BackgroundElementSpriteConstants.SINGLEBUSHSOURCE.Y,
                (int)BackgroundElementSpriteConstants.SINGLEBUSHDIMENSIONS.X, (int)BackgroundElementSpriteConstants.SINGLEBUSHDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)BackgroundElementSpriteConstants.SINGLEBUSHDIMENSIONS.X, (int)BackgroundElementSpriteConstants.SINGLEBUSHDIMENSIONS.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();

        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)BackgroundElementSpriteConstants.SINGLEBUSHDIMENSIONS.X, (int)BackgroundElementSpriteConstants.SINGLEBUSHDIMENSIONS.Y); }
        }
    }
}
