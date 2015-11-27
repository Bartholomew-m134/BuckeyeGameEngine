using Game.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;
using Game.Utilities;

namespace Game.Blocks.BlockSprites
{
    public class UndergroundBreakingBlockSprite : ISprite
    {
        private Texture2D spriteSheet;
        private Rectangle sourceRectangle = new Rectangle((int)BlockSpriteConstants.UNDERGROUNDBREAKINGBLOCKSOURCE.X, (int)BlockSpriteConstants.UNDERGROUNDBREAKINGBLOCKSOURCE.Y,
            (int)BlockSpriteConstants.GENERICBLOCKDIMENSIONS.X, (int)BlockSpriteConstants.GENERICBLOCKDIMENSIONS.Y);

        public UndergroundBreakingBlockSprite(Texture2D spriteSheet)
        {
            this.spriteSheet = spriteSheet;
        }
        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Vector2 location)
        {
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)BlockSpriteConstants.GENERICBLOCKDIMENSIONS.X, (int)BlockSpriteConstants.GENERICBLOCKDIMENSIONS.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)BlockSpriteConstants.GENERICBLOCKDIMENSIONS.X, (int)BlockSpriteConstants.GENERICBLOCKDIMENSIONS.Y); }
        }
    }
}