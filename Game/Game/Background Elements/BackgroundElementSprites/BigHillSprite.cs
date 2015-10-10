﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Background_Elements.BackgroundElementSprites
{
    class BigHillSprite:ISprite
    {
        private Texture2D Texture { get; set; }
        private int width = 81;
        private int height = 35;
        private int sourceX = 85;
        private int sourceY = 4;
        public BigHillSprite(Texture2D texture)
        {
            Texture = texture;


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
