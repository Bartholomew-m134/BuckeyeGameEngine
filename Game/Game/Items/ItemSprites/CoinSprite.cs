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
    public class CoinSprite : IItemSprite
    {

        private Texture2D Texture { get; set; }
        private int currentFrame;
        private int totalFrames;
        private int width = 9;
        private int height = 15;
        private int sourceX = 127;
        private int sourceY = 94;
        private int distanceBetweenSprites = 30;
        private int riseY;
        private bool isRisingUpward;
        private bool isReleased;

        public CoinSprite(Texture2D texture)
        {
            Texture = texture;
            currentFrame = 0;
            totalFrames = 4;
            riseY = 0;
            isRisingUpward = true;
            isReleased = false;
        }

        public void Update() {
            currentFrame++;
            if (currentFrame == totalFrames)
            {
                currentFrame = 0;
            }

            if(isReleased)
            {
                if ((riseY < 30) && (isRisingUpward))
                {
                   riseY += 7;
                }
                else
                {
                    isRisingUpward = false;
                    riseY -= 7;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location) {
            
            sourceX = 127 + distanceBetweenSprites*currentFrame;

            Rectangle sourceRectangle = new Rectangle(sourceX, sourceY, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            isReleased = false;
            riseY = 0;

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();

        }

        public void RiseDraw(SpriteBatch spriteBatch, Vector2 location)
        {
            sourceX = 127 + distanceBetweenSprites * currentFrame;
            Rectangle sourceRectangle = new Rectangle(sourceX, sourceY, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            isReleased = true;
            if (riseY > 0)
            {
                destinationRectangle.Y -= riseY;
            }
            
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
