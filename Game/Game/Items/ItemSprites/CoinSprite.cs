using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Items.ItemSprites
{
    public class CoinSprite : ISprite
    {

        private Texture2D Texture { get; set; }
        private int currentFrame;
        private int totalFrames;

        private Game1 myGame;
        public CoinSprite(Texture2D texture, Game1 game)
        {
            Texture = texture;
            myGame = game;
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
            int width = 9;
            int height = 15;
            int sourceX = 127 + 30*currentFrame;
            int sourceY = 94;
            

            Rectangle sourceRectangle = new Rectangle(sourceX, sourceY, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();

        }

    }
}
