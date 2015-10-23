using Game.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks.BlockSprites
{
    public class BrickBlockSprite : IBlockSprite
    {
        private Texture2D spriteSheet;
        private int width;
        private int height;
        private int sheetXLocation;
        private int sheetYLocation;
        private int bumpY;
        private bool isBumpingUpward;
        public bool isBumped;

        public BrickBlockSprite(Texture2D spriteSheet)
        {
            this.spriteSheet = spriteSheet;
            width = 16;
            height = 16;
            sheetXLocation = 16;
            sheetYLocation = 0;
            bumpY = 0;
            isBumpingUpward = true;
            isBumped = false;
        }

        public void Update()
        {
            if (isBumped){
                if ((bumpY < 30) && (isBumpingUpward))
                {
                    bumpY+=3;
                }
                else
                {
                    isBumpingUpward = false;
                    bumpY-=3;
                }
            }
        }
       

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(sheetXLocation, sheetYLocation, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);
            isBumped = false;
            bumpY = 0;
            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void BumpDraw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(sheetXLocation, sheetYLocation, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);
            isBumped = true;
            if (bumpY > 0)
            {
                destinationRectangle.Y -= bumpY;
            }
            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2(width, height); }
        }
    }
}
