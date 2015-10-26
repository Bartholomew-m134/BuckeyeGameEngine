using Game.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Game.Blocks.BlockSprites
{
    class BrickDebrisSprite : ISprite
    {
        private Texture2D spriteSheet;
        private int width;
        private int height;
        private int sheetXLocation;
        private int sheetYLocation;
        private int timer;
        private Vector2 topLeftDestination;
        private Vector2 topRightDestination;
        private Vector2 bottomLeftDestination;
        private Vector2 bottomRightDestination;
        private Vector2 adjustment;

        public BrickDebrisSprite(Texture2D spriteSheet)
        {
            this.spriteSheet = spriteSheet;
            width = 8;
            height = 8;
            sheetXLocation = 304;
            sheetYLocation = 112;
        }

        public void Update()
        {
            if (timer < 5)
                adjustment += new Vector2(1, 6);
            else
                adjustment += new Vector2(1, -6);
            timer++;
        }

        public void Draw(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(sheetXLocation, sheetYLocation, width, height);

            topLeftDestination.X = location.X - adjustment.X;
            topLeftDestination.Y = location.Y - adjustment.Y;

            topRightDestination.X = location.X + adjustment.X + 8;
            topRightDestination.Y = location.Y - adjustment.Y;

            bottomLeftDestination.X = location.X + adjustment.X;
            bottomLeftDestination.Y = location.Y - adjustment.Y + 8;

            bottomRightDestination.X = location.X - adjustment.X + 8;
            bottomRightDestination.Y = location.Y - adjustment.Y + 8;

            if (timer <75){
                spriteBatch.Begin();
                spriteBatch.Draw(spriteSheet, topLeftDestination, sourceRectangle, Color.White);
                spriteBatch.Draw(spriteSheet, topRightDestination, sourceRectangle, Color.White);
                spriteBatch.Draw(spriteSheet, bottomLeftDestination, sourceRectangle, Color.White);
                spriteBatch.Draw(spriteSheet, bottomRightDestination, sourceRectangle, Color.White);
                spriteBatch.End();
            }
            
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2(width, height); }
        }

    }
}
