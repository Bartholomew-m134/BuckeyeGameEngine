using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Items.ItemSprites
{
    public class StarSprite:ISprite
    {
        private Texture2D Texture { get; set; }
        private int currentFrame;
        private int totalFrames;
        private int delayBetweenFrames = 10;
        private Game1 myGame;
        private int width = 17;
        private int height = 17;
        private int sourceX = 3;
        private int sourceY = 93;
        private int distanceBetweenSprites = 30;

        public StarSprite(Texture2D texture, Game1 game)
        {
            Texture = texture;
            myGame = game;
            currentFrame = 0;
            totalFrames = 4;

        }

        public void Update()
        {
            if (delayBetweenFrames == 10)
            {
                delayBetweenFrames = 0;
                currentFrame++;
                if (currentFrame == totalFrames)
                {
                    currentFrame = 0;

                }
            }
            else
            {

                delayBetweenFrames++;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location) {

            currentFrame = sourceX + currentFrame * distanceBetweenSprites;
            

            Rectangle sourceRectangle = new Rectangle(sourceX, sourceY, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();

        }

    }

}
