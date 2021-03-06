﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities.Constants;
using Game.Utilities;

namespace Game.Mario.MarioSprites
{
    public class DeadMarioSprite : IMarioSprite
    {
        private Texture2D spriteSheet;
        public DeadMarioSprite(Texture2D spriteSheet)
        {
            this.spriteSheet = spriteSheet;
        }
        public void Update()
        {           
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)MarioSpriteConstants.DEADMARIOSOURCECOORDINATES.X, (int)MarioSpriteConstants.DEADMARIOSOURCECOORDINATES.Y,
                (int)MarioSpriteConstants.DEADMARIOWIDTHHIEGHT.X, (int)MarioSpriteConstants.DEADMARIOWIDTHHIEGHT.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)MarioSpriteConstants.DEADMARIOWIDTHHIEGHT.X, (int)MarioSpriteConstants.DEADMARIOSOURCECOORDINATES.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
        public void StarDraw(SpriteBatch spriteBatch, Vector2 location)
        {
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)MarioSpriteConstants.DEADMARIOWIDTHHIEGHT.X, (int)MarioSpriteConstants.DEADMARIOWIDTHHIEGHT.Y); }
        }
    }
}
