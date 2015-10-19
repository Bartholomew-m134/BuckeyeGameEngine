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
        private int width = 32;
        private int height = 32;
        private int sourceX = 0;
        private int sourceY = 128;
        private Texture2D Texture { get; set; }

        public PipeSprite(Texture2D texture)
        {
            Texture = texture;

            width = 32;
            height = 32;
            sourceX = 0;
            sourceY = 128;

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