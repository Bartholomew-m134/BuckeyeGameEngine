using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;

namespace Game.Items.ItemSprites
{
    public class CoinSprite : ISprite
    {

        private Texture2D Texture { get; set; }
        private int currentFrame;
        private int totalFrames;
        private int width = 9;
        private int height = 15;
        private int sourceX = 127;
        private int sourceY = 94;
        private int distanceBetweenSprites = 30;

        public CoinSprite(Texture2D texture)
        {
            Texture = texture;
            currentFrame = 0;
            totalFrames = 4;

        }

        public void Update() {
                currentFrame++;
                if (currentFrame == totalFrames)
                {
                    currentFrame = 0;

                }

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location) {
            
            sourceX = 127 + distanceBetweenSprites*currentFrame;
       
            

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
