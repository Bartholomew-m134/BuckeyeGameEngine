using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.ProjectBuckeye;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Game.Utilities.Constants;

namespace Game.ProjectBuckeye.EnemyClasses.WolverineSprites
{
    public class WolverineDownLeftSprite : ISprite
    {
        private Texture2D spriteSheet;

        public WolverineDownLeftSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)WolverineEnemyConstant.FALL_LOOKING_LEFT_SOURCE.X, (int)WolverineEnemyConstant.FALL_LOOKING_LEFT_SOURCE.Y,
                (int)WolverineEnemyConstant.FALL_LOOKING_LEFT_DIMENSIONS.X, (int)WolverineEnemyConstant.FALL_LOOKING_LEFT_DIMENSIONS.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, location, sourceRectangle, Color.White, 0f, Vector2.Zero, WolverineEnemyConstant.SPRITE_SCALE_FACTOR, SpriteEffects.None, 0f);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return WolverineEnemyConstant.FALL_LOOKING_LEFT_DIMENSIONS * WolverineEnemyConstant.SPRITE_SCALE_FACTOR; }
        }
    }
}
