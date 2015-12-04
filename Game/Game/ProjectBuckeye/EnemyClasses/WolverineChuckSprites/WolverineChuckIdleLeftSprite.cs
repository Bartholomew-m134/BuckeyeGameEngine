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
    public class WolverineChuckIdleLeftSprite : ISprite
    {
        private Texture2D spriteSheet;
        private Vector2 frameDimensions = WolverineEnemyConstant.CHUCK_LEFT_IDLE_DIMENSIONS;
        private Vector2 frameLocation = WolverineEnemyConstant.CHUCK_LEFT_IDLE_SOURCE;

        public WolverineChuckIdleLeftSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)frameLocation.X, (int)frameLocation.Y, (int)frameDimensions.X, (int)frameDimensions.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, location, sourceRectangle, Color.White, 0f, Vector2.Zero, WolverineEnemyConstant.CHUCK_SPRITE_SCALE_FACTOR, SpriteEffects.None, 0f);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return frameDimensions*WolverineEnemyConstant.CHUCK_SPRITE_SCALE_FACTOR; }
        }
    }
}
