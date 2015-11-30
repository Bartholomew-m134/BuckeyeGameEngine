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
    public class BrickDebrisSprite : ISprite
    {
        private Texture2D spriteSheet;
        private int timer;
        private Vector2 topLeftDestination;
        private Vector2 topRightDestination;
        private Vector2 bottomLeftDestination;
        private Vector2 bottomRightDestination;
        private Vector2 adjustment;
        private Rectangle sourceRectangle = new Rectangle((int)BlockSpriteConstants.BRICKDEBRISBLOCKSOURCE.X, (int)BlockSpriteConstants.BRICKDEBRISBLOCKSOURCE.Y,
            (int)BlockSpriteConstants.BRICKDEBRISBLOCKDIMENSIONS.X, (int)BlockSpriteConstants.BRICKDEBRISBLOCKDIMENSIONS.Y);

        public BrickDebrisSprite(Texture2D spriteSheet)
        {
            this.spriteSheet = spriteSheet;
        }

        public void Update()
        {
            if (timer < BlockSpriteConstants.BRICKDEBRISUPDATEDELAY)
                adjustment += BlockSpriteConstants.BRICKBLOCKUPADJUSTMENT;
            else
                adjustment += BlockSpriteConstants.BRICKBLOCKDOWNADJUSTMENT;
            timer++;
        }

        public void Draw(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Vector2 location)
        {
            topLeftDestination.X = location.X - adjustment.X;
            topLeftDestination.Y = location.Y - adjustment.Y;

            topRightDestination.X = location.X + adjustment.X + BlockSpriteConstants.BRICKDEBRISADJUST;
            topRightDestination.Y = location.Y - adjustment.Y;

            bottomLeftDestination.X = location.X + adjustment.X;
            bottomLeftDestination.Y = location.Y - adjustment.Y + BlockSpriteConstants.BRICKDEBRISADJUST;

            bottomRightDestination.X = location.X - adjustment.X + BlockSpriteConstants.BRICKDEBRISADJUST;
            bottomRightDestination.Y = location.Y - adjustment.Y + BlockSpriteConstants.BRICKDEBRISADJUST;

            if (timer < BlockSpriteConstants.BRICKDEBRISTIMER)
            {
                spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
                spriteBatch.Draw(spriteSheet, topLeftDestination, sourceRectangle, Color.White);
                spriteBatch.Draw(spriteSheet, topRightDestination, sourceRectangle, Color.White);
                spriteBatch.Draw(spriteSheet, bottomLeftDestination, sourceRectangle, Color.White);
                spriteBatch.Draw(spriteSheet, bottomRightDestination, sourceRectangle, Color.White);
                spriteBatch.End();
            }
            
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)BlockSpriteConstants.BRICKDEBRISBLOCKDIMENSIONS.X, (int)BlockSpriteConstants.BRICKDEBRISBLOCKDIMENSIONS.Y); }
        }

    }
}
