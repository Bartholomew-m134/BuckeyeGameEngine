﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Mario.MarioSprites
{
    public class FireRightIdleMarioSprite : ISprite
    {
        private Texture2D spriteSheet;
        private int width;
        private int height;
        private int sheetXLocation;
        private int sheetYLocation;
        public FireRightIdleMarioSprite(Texture2D spriteSheet) 
        {
            this.spriteSheet = spriteSheet;
            width = 15;
            height = 31;
            sheetXLocation = 209;
            sheetYLocation = 122;
        }
        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(sheetXLocation, sheetYLocation, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}