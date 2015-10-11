using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Enemies.KoopaClasses.GreenKoopaSprites
{
    class GreenKoopaWalkingLeftSprite : ISprite
    {
        private Texture2D spriteSheet;
        private int currentFrame;
        private int totalFrames = 2;
        private int delayBetweenFrames = 0;
        private Vector2[] spriteLocations;
        private Vector2[] spriteDimensions;

        public GreenKoopaWalkingLeftSprite(Texture2D texture)
        {
            spriteSheet = texture;
            currentFrame = 0;
            spriteLocations = new Vector2[2];
            spriteDimensions = new Vector2[2];

            spriteLocations[0].X = 180;
            spriteLocations[0].Y = 2;

            spriteDimensions[0].X = 16;
            spriteDimensions[0].Y = 21;

            spriteLocations[1].X = 150;
            spriteLocations[1].Y = 2;

            spriteDimensions[1].X = 15;
            spriteDimensions[1].Y = 22;
        }

        public void Update()
        {
            if (delayBetweenFrames == 2)
            {
                delayBetweenFrames = 0;
                currentFrame++;
                if (currentFrame == totalFrames)
                    currentFrame = 0;
            }
            else
            {
                delayBetweenFrames++;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)spriteLocations[currentFrame].X, (int)spriteLocations[currentFrame].Y, (int)spriteDimensions[currentFrame].X, (int)spriteDimensions[currentFrame].Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)spriteDimensions[currentFrame].X, (int)spriteDimensions[currentFrame].Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return spriteDimensions[currentFrame]; }
        }
    }
}
