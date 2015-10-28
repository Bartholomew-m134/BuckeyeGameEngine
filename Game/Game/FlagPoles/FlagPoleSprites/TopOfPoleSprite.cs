﻿using Game.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.FlagPoles.FlagPoleSprites
{
    public class TopOfPoleSprite : ISprite
    {
        private Texture2D Texture { get; set; }
        private int width;
        private int height;
        private int sourceX;
        private int sourceY;
        public TopOfPoleSprite(Texture2D texture)
        {
            Texture = texture;
            width = 16;
            height = 16;
            sourceX = 320;
            sourceY = 340;

        }

        public void Update() { 
        
        
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location) {
            
            

            Rectangle sourceRectangle = new Rectangle(sourceX, sourceY, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();

        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2(width, height); }
        }
    }
}
