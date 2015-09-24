using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Enemies.GreenKoopaClasses.GreenKoopaSprites
{
    class GreenKoopaHidingInShellSprite : ISprite
    {
        private Game1 myGame;
        private Texture2D spriteSheet;

        public GreenKoopaHidingInShellSprite(Texture2D texture, Game1 game)
        {
            spriteSheet = texture;
            myGame = game;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(361, 5, 14, 13);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 14, 13);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
