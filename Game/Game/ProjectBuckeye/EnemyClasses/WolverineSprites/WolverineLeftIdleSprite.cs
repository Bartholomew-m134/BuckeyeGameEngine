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
    public class WolverineLeftIdleSprite : ISprite
    {
        private Texture2D spriteSheet;
        private int frameDelay = 0;
        private int currentFrame = 0;
        private Vector2 frameDimensions = new Vector2(WolverineEnemyConstant.LEFT_FRAME_4_DIMENSIONS.X, WolverineEnemyConstant.LEFT_FRAME_4_DIMENSIONS.Y);
        private Vector2 frameLocation = new Vector2(WolverineEnemyConstant.LEFT_FRAME_4_SOURCE.X, WolverineEnemyConstant.LEFT_FRAME_4_SOURCE.Y);

        public WolverineLeftIdleSprite(Texture2D texture)
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
            Rectangle sourceRectangle = new Rectangle((int)frameLocation.X, (int)frameLocation.Y,
                (int)frameDimensions.X, (int)frameDimensions.Y);

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
