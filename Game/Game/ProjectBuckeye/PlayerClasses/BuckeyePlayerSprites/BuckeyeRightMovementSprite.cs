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
    public class BuckeyeRightMovementSprite : ISprite
    {
        private Texture2D spriteSheet;
        private int frameDelay = 0;
        private int currentFrame = 0;
        private Vector2[] animationFrameDimensions = new Vector2[4] { BuckeyePlayerSpriteConstants.RIGHT_FRAME_1_DIMENSIONS, BuckeyePlayerSpriteConstants.RIGHT_FRAME_2_DIMENSIONS,
            BuckeyePlayerSpriteConstants.RIGHT_FRAME_3_DIMENSIONS, BuckeyePlayerSpriteConstants.RIGHT_FRAME_4_DIMENSIONS};
        private Vector2[] animationFrameLocation = new Vector2[4] { BuckeyePlayerSpriteConstants.RIGHT_FRAME_1_SOURCE, BuckeyePlayerSpriteConstants.RIGHT_FRAME_2_SOURCE,
            BuckeyePlayerSpriteConstants.RIGHT_FRAME_3_SOURCE, BuckeyePlayerSpriteConstants.RIGHT_FRAME_4_SOURCE };

        public BuckeyeRightMovementSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {
            if (frameDelay == BuckeyePlayerSpriteConstants.MOVEMENT_FRAME_DELAY)
            {
                currentFrame++;
                frameDelay = 0;
            }
            if (currentFrame == BuckeyePlayerSpriteConstants.MOVEMENT_FRAME_MAX)
            {
                currentFrame = 0;
            }
            frameDelay++;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)animationFrameLocation[currentFrame].X, (int)animationFrameLocation[currentFrame].Y,
                (int)animationFrameDimensions[currentFrame].X, (int)animationFrameDimensions[currentFrame].Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, location, sourceRectangle, Color.White, 0f, Vector2.Zero, BuckeyePlayerSpriteConstants.SPRITE_SCALE_FACTOR, SpriteEffects.None, 0f);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2(16, 32); }
        }
    }
}
