using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Enemies.GoombaClasses.GoombaSprites
{
    class GoombaSmashedSprite : ISprite
    {
        private Texture2D spriteSheet;
        private Vector2 spriteLocations;
        private Vector2 spriteDimensions;

        public GoombaSmashedSprite(Texture2D texture)
        {
            spriteSheet = texture;

            spriteLocations.X = 60;
            spriteLocations.Y = 8;

            spriteDimensions.X = 16;
            spriteDimensions.Y = 8;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)spriteLocations.X, (int)spriteLocations.Y, (int)spriteDimensions.X, (int)spriteDimensions.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)spriteDimensions.X, (int)spriteDimensions.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        Vector2 SpriteDimensions
        {
            get { return spriteDimensions; }
        }
    }
}
