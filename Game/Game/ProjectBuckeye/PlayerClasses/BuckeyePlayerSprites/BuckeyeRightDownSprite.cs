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
    public class BuckeyeRightDownSprite : ISprite
    {
        private Texture2D spriteSheet;

        public BuckeyeRightDownSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)BuckeyePlayerSpriteConstants.FALL_LOOKING_RIGHT_SOURCE.X, (int)BuckeyePlayerSpriteConstants.FALL_LOOKING_RIGHT_SOURCE.Y,
                (int)BuckeyePlayerSpriteConstants.FALL_LOOKING_RIGHT_DIMENSIONS.X, (int)BuckeyePlayerSpriteConstants.FALL_LOOKING_RIGHT_DIMENSIONS.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, location, sourceRectangle, Color.White, 0f, Vector2.Zero, BuckeyePlayerSpriteConstants.SPRITE_SCALE_FACTOR, SpriteEffects.None, 0f);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2(32, 16); }
        }
    }
}
