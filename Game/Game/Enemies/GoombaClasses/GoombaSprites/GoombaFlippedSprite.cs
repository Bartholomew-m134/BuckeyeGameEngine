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
        // Temporary Positioning
        private int xPosition = 400;
        private int yPosition = 200;

        public GoombaFlippedSprite(Texture2D texture, Game1 game)
        {
            spriteSheet = texture;
            myGame = game;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(0, 4, 16, 16);
            // Temporary Destination Location
            Rectangle destinationRectangle = new Rectangle(xPosition, yPosition, 16, 16);

            spriteBatch.Begin();
            // Update after learning to flip the sprite
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
