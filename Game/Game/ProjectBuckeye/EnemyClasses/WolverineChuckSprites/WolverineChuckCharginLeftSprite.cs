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

namespace Game.ProjectBuckeye.EnemyClasses.WolverineChuckSprites
{
    public class WolverineChuckCharginLeftSprite : ISprite
    {
        private Texture2D spriteSheet;
        private int currentFrame = 0;
        private Vector2[] animationFrameDimensions = new Vector2[2] { WolverineEnemyConstant.CHUCK_LEFT_FRAME_2_DIMENSIONS, WolverineEnemyConstant.CHUCK_LEFT_FRAME_1_DIMENSIONS };
        private Vector2[] animationFrameLocation = new Vector2[2] { WolverineEnemyConstant.CHUCK_LEFT_FRAME_2_SOURCE, WolverineEnemyConstant.CHUCK_LEFT_FRAME_1_SOURCE };


        public WolverineChuckCharginLeftSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == WolverineEnemyConstant.CHUCK_MOVEMENT_FRAME_MAX)
            {
                currentFrame = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)animationFrameLocation[currentFrame].X, (int)animationFrameLocation[currentFrame].Y,
                (int)animationFrameDimensions[currentFrame].X, (int)animationFrameDimensions[currentFrame].Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, location, sourceRectangle, Color.White, 0f, Vector2.Zero, WolverineEnemyConstant.CHUCK_SPRITE_SCALE_FACTOR, SpriteEffects.None, 0f);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return animationFrameDimensions[currentFrame] * WolverineEnemyConstant.CHUCK_SPRITE_SCALE_FACTOR; }
        }
    }
}
