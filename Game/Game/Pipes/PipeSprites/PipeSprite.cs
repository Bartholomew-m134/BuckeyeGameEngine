using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;

namespace Game.Pipes.PipeSprites
{
    class PipeSprite : ISprite
    {
        private int width;
        private int height;
        private int sourceX;
        private int sourceY;
        private Texture2D Texture { get; set; }

        public PipeSprite(Texture2D texture)
        {
            Texture = texture;

            width = 32;
            height = 32;
            sourceX = 309;
            sourceY = 417;

        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
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