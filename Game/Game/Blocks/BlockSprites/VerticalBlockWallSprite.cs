using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks.BlockSprites
{
    public class VerticalBlockWallSprite : ISprite
    {
        private Texture2D spriteSheet;
        private Rectangle sourceRectangle = new Rectangle((int)BlockSpriteConstants.VERTICALBLOCKWALLSOURCE.X, (int)BlockSpriteConstants.VERTICALBLOCKWALLSOURCE.Y,
            (int)BlockSpriteConstants.VERTICALBLOCKWALLDIMENSIONS.X, (int)BlockSpriteConstants.VERTICALBLOCKWALLDIMENSIONS.Y);

        public VerticalBlockWallSprite(Texture2D spriteSheet)
        {
            this.spriteSheet = spriteSheet;
        }
        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)BlockSpriteConstants.VERTICALBLOCKWALLDIMENSIONS.X, (int)BlockSpriteConstants.VERTICALBLOCKWALLDIMENSIONS.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)BlockSpriteConstants.VERTICALBLOCKWALLDIMENSIONS.X, (int)BlockSpriteConstants.VERTICALBLOCKWALLDIMENSIONS.Y); }
        }
    }
}
