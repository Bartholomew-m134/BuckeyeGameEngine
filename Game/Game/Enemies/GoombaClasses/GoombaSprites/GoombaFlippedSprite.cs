using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Enemies.GoombaClasses.GoombaSprites
{
    class GoombaFlippedSprite : ISprite
    {
        private Game1 myGame;
        private Texture2D spriteSheet;
        private Vector2 spriteLocations;
        private Vector2 spriteDimensions;

        public GoombaFlippedSprite(Texture2D texture, Game1 game)
        {
            spriteSheet = texture;
            myGame = game;

            spriteLocations.X = 0;
            spriteLocations.Y = 4;

            spriteDimensions.X = 16;
            spriteDimensions.Y = 16;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)spriteLocations.X, (int)spriteLocations.Y, (int)spriteDimensions.X, (int)spriteDimensions.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)spriteDimensions.X, (int)spriteDimensions.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.FlipVertically, 0);
            spriteBatch.End();
        }
    }
}
