using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.ProjectBuckeye;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Game.Utilities.Constants;
using Game.Utilities;

namespace Game.ProjectBuckeye.EnemyClasses.WolverineSprites
{
    public class WolverineMovingRightSprite : ISprite
    {
        private Texture2D spriteSheet;
        private int frameDelay = 0;
        private int currentFrame = 0;
        private Vector2[] animationFrameDimensions = new Vector2[4] { WolverineEnemyConstant.RIGHT_FRAME_1_DIMENSIONS, WolverineEnemyConstant.RIGHT_FRAME_2_DIMENSIONS,
            WolverineEnemyConstant.RIGHT_FRAME_3_DIMENSIONS, WolverineEnemyConstant.RIGHT_FRAME_4_DIMENSIONS};
        private Vector2[] animationFrameLocation = new Vector2[4] { WolverineEnemyConstant.RIGHT_FRAME_1_SOURCE, WolverineEnemyConstant.RIGHT_FRAME_2_SOURCE,
            WolverineEnemyConstant.RIGHT_FRAME_3_SOURCE, WolverineEnemyConstant.RIGHT_FRAME_4_SOURCE };

        public WolverineMovingRightSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {
            if (frameDelay == WolverineEnemyConstant.MOVEMENT_FRAME_DELAY)
            {
                currentFrame++;
                frameDelay = 0;
            }
            if (currentFrame == WolverineEnemyConstant.MOVEMENT_FRAME_MAX)
            {
                currentFrame = 0;
            }
            frameDelay++;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)animationFrameLocation[currentFrame].X, (int)animationFrameLocation[currentFrame].Y,
                (int)animationFrameDimensions[currentFrame].X, (int)animationFrameDimensions[currentFrame].Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, location, sourceRectangle, Color.White, 0f, Vector2.Zero, WolverineEnemyConstant.SPRITE_SCALE_FACTOR, SpriteEffects.None, 0f);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2(16, 32); }
        }
    }
}
