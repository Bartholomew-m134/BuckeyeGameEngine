using Game.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Background_Elements.BackgroundElementSprites
{
    class StartSprite : ISprite
    {
        private Texture2D Texture;
        private int width = 879;
        private int height = 479;
        private int sourceX = 0;
        private int sourceY = 0;
        public StartSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(sourceX, sourceY, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);
            float scale = .3f;
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, location, null,
        Color.White, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);

            //spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2(width, height); }
        }
    }
}