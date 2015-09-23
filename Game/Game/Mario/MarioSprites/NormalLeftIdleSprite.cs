using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Mario.MarioSprites
{
    public class NormalLeftIdleSprite : ISprite
    {
        private Texture2D Texture { get; set; }


        public NormalLeftIdleSprite(Texture2D texture, Game1 game) {

            
        }
        void Update()
        {

        }

        void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle();
            Rectangle destinationRectangle = new Rectangle();

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
