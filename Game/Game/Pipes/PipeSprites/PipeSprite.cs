using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Pipes.PipeSprites
{
    class PipeSprite : ISprite
    {
        private Texture2D Texture { get; set; }

        private Game1 myGame;
        public PipeSprite(Texture2D texture, Game1 game)
        {
            Texture = texture;
            myGame = game;

        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int width = 32;
            int height = 32;
            int sourceX = 0;
            int sourceY = 128;


            Rectangle sourceRectangle = new Rectangle(sourceX, sourceY, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();

        }
    }
}