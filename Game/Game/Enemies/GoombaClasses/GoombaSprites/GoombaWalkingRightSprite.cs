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
        // Temporary Positioning
        private int xPosition = 400;
        private int yPosition = 200;

        public GoombaWalkingRightSprite(Texture2D texture, Game1 game)
        {
            spriteSheet = texture;
            currentFrame = 0;
            myGame = game;
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
            if (currentFrame == 0)
            {
                Rectangle sourceRectangle = new Rectangle(0, 4, 16, 16);
                // Temporary Destination Location
                Rectangle destinationRectangle = new Rectangle(xPosition, yPosition, 16, 16);

                spriteBatch.Begin();
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
                spriteBatch.End();
            }
            else if (currentFrame == 1)
            {
                Rectangle sourceRectangle = new Rectangle(30, 4, 16, 16);
                // Temporary Destination Location
                Rectangle destinationRectangle = new Rectangle(xPosition, yPosition, 16, 16);

                spriteBatch.Begin();
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
                spriteBatch.End();
            }
    }
}
