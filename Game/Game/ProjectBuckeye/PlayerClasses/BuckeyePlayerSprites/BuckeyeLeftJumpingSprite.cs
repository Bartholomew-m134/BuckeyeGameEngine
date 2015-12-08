using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities.Constants;
using Game.Utilities;

namespace Game.ProjectBuckeye.PlayerClasses.BuckeyePlayerSprites
{
    public class BuckeyeLeftJumpingSprite : ISprite
    {
        private Texture2D spriteSheet;

        public BuckeyeLeftJumpingSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)BuckeyePlayerSpriteConstants.LEFT_FRAME_2_SOURCE.X, (int)BuckeyePlayerSpriteConstants.LEFT_FRAME_2_SOURCE.Y,
                (int)BuckeyePlayerSpriteConstants.LEFT_FRAME_2_DIMENSIONS.X, (int)BuckeyePlayerSpriteConstants.LEFT_FRAME_2_DIMENSIONS.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, location, sourceRectangle, Color.White, 0f, Vector2.Zero, BuckeyePlayerSpriteConstants.SPRITE_SCALE_FACTOR, SpriteEffects.None, 0f);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2(16, 32); }
        }
    }
}
