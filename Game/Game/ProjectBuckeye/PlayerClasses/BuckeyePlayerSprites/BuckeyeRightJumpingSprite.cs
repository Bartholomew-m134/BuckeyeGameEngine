using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities.Constants;

namespace Game.ProjectBuckeye.PlayerClasses.BuckeyePlayerSprites
{
    public class BuckeyeRightJumpingSprite : ISprite
    {
        private Texture2D spriteSheet;

        public BuckeyeRightJumpingSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)BuckeyePlayerSpriteConstants.RIGHT_FRAME_3_SOURCE.X, (int)BuckeyePlayerSpriteConstants.RIGHT_FRAME_3_SOURCE.Y,
                (int)BuckeyePlayerSpriteConstants.RIGHT_FRAME_3_DIMENSIONS.X, (int)BuckeyePlayerSpriteConstants.RIGHT_FRAME_3_DIMENSIONS.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, location, sourceRectangle, Color.White, 0f, Vector2.Zero, BuckeyePlayerSpriteConstants.SPRITE_SCALE_FACTOR, SpriteEffects.None, 0f);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return BuckeyePlayerSpriteConstants.RIGHT_FRAME_3_DIMENSIONS * BuckeyePlayerSpriteConstants.SPRITE_SCALE_FACTOR; }
        }
    }
}
