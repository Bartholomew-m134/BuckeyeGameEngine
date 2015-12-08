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
    public class WolverineDownRightSprite : ISprite
    {
        private Texture2D spriteSheet;

        public WolverineDownRightSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)WolverineEnemyConstant.FALL_LOOKING_RIGHT_SOURCE.X, (int)WolverineEnemyConstant.FALL_LOOKING_RIGHT_SOURCE.Y,
                (int)WolverineEnemyConstant.FALL_LOOKING_RIGHT_DIMENSIONS.X, (int)WolverineEnemyConstant.FALL_LOOKING_RIGHT_DIMENSIONS.Y);

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
