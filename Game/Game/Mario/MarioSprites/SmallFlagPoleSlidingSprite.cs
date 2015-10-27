using Game.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Mario.MarioSprites
{
    class SmallFlagPoleSlidingSprite : IMarioSprite
    {
        private int toggle;
        private Texture2D spriteSheet;
        private int width;
        private int height;
        private Vector2 currentSourceLocation;
        private int frameCounter;
        private int delayCounter;
        public SmallFlagPoleSlidingSprite(Texture2D spriteSheet)
        {
            toggle = 0;
            frameCounter = 0;
            delayCounter = 0;
            this.spriteSheet = spriteSheet;
            width = 14;
            height = 16;
            currentSourceLocation.X = 331;
            currentSourceLocation.Y = 30;
        }
        public void Update()
        {
            if (frameCounter ==0 && delayCounter ==2){
                currentSourceLocation.X = 331;
                currentSourceLocation.Y = 30;
                frameCounter = 1;
                delayCounter = 0;
            }
            else if (delayCounter == 2){
                currentSourceLocation.X = 361;
                currentSourceLocation.Y = 30;
                frameCounter = 0;
                delayCounter = 0;
            }
            delayCounter++;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentSourceLocation.X, (int)currentSourceLocation.Y, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void StarDraw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentSourceLocation.X, (int)currentSourceLocation.Y, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            if (toggle < 5)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.Brown);
                spriteBatch.End();
                toggle++;
            }

            else if (toggle > 6 && toggle < 10)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.YellowGreen);
                spriteBatch.End();
                toggle++;
            }

            else
            {
                spriteBatch.Begin();
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.Orange);
                spriteBatch.End();
                if (toggle < 15)
                {
                    toggle++;
                }
                else
                {
                    toggle = 0;
                }
            }

        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2(width, height); }
        }
    }
}
