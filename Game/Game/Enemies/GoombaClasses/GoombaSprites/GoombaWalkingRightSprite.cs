using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Enemies.GoombaClasses.GoombaSprites
{
    class GoombaWalkingRightSprite : ISprite
    {
        private Game1 myGame;
        private Texture2D spriteSheet;
        private int currentFrame;
        private int totalFrames = 2;
        private int delayBetweenFrames = 0;
        private Vector2[] spriteLocations;
        private Vector2 spriteDimensions;

        public GoombaWalkingRightSprite(Texture2D texture, Game1 game)
        {
            spriteSheet = texture;
            currentFrame = 0;
            myGame = game;
            spriteLocations = new Vector2[2];

            spriteLocations[0].X = 0;
            spriteLocations[0].Y = 4;

            spriteLocations[1].X = 30;
            spriteLocations[1].Y = 4;

            spriteDimensions.X = 16;
            spriteDimensions.Y = 16;
        }

        public void Update()
        {
            if (delayBetweenFrames == 10)
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
            Rectangle sourceRectangle = new Rectangle((int)spriteLocations[currentFrame].X, (int)spriteLocations[currentFrame].Y, (int)spriteDimensions.X, (int)spriteDimensions.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)spriteDimensions.X, (int)spriteDimensions.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
