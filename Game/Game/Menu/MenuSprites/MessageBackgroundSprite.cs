using Game.Interfaces;
using Game.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Menu.MenuSprites
{
    public class MessageBackgroundSprite : ISprite
    {
        private Texture2D texture;
        private Rectangle sourceRectangle = new Rectangle(3, 3, 800, 212);

        public MessageBackgroundSprite(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            //Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,0,0);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            spriteBatch.Draw(texture, location, sourceRectangle, Color.White, 0f, Vector2.Zero, .9f, SpriteEffects.None, 0f);
            spriteBatch.End();
        }

        public Microsoft.Xna.Framework.Vector2 SpriteDimensions
        {
            get { return new Microsoft.Xna.Framework.Vector2(); }
        }
    }
}
