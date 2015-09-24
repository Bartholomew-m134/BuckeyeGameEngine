using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Enemies.GreenKoopaClasses.GreenKoopaSprites
{
    class GreenKoopaEmergingFromShellSprite
    {
        private Game1 myGame;
        private Texture2D spriteSheet;

        public GreenKoopaEmergingFromShellSprite(Texture2D texture, Game1 game)
        {
            spriteSheet = texture;
            myGame = game;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(331, 4, 14, 15);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 14, 15);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
