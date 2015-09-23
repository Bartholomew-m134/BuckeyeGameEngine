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
        private Game1 myGame;
        private Texture2D spriteSheet;
        // Temporary Positioning
        private int xPosition = 400;
        private int yPosition = 200;

        public GoombaSmashedSprite(Texture2D texture, Game1 game)
        {
            spriteSheet = texture;
            myGame = game;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(60, 8, 16, 8);
            // Temporary Destination Location
            Rectangle destinationRectangle = new Rectangle(xPosition, yPosition, 16, 8);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
