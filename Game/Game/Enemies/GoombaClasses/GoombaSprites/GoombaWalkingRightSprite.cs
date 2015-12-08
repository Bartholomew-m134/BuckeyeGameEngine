using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities.Constants;
using Game.Utilities;

namespace Game.Enemies.GoombaClasses.GoombaSprites
{
    class GoombaWalkingRightSprite : ISprite
    {
        private Texture2D spriteSheet;
        private int currentFrame;

        public GoombaWalkingRightSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {
                currentFrame++;
                if (currentFrame == EnemySpriteConstants.TOTALGOOMBAWALKINGFRAMES)
                    currentFrame = EnemySpriteConstants.RESETTOZERO;
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)EnemySpriteConstants.GOOMBAWALKINGRIGHTFRAMES[currentFrame].X, (int)EnemySpriteConstants.GOOMBAWALKINGRIGHTFRAMES[currentFrame].Y,
                (int)EnemySpriteConstants.GOOMBAWALKINGRIGHTDIMENSIONS.X, (int)EnemySpriteConstants.GOOMBAWALKINGRIGHTDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)EnemySpriteConstants.GOOMBAWALKINGRIGHTDIMENSIONS.X, (int)EnemySpriteConstants.GOOMBAWALKINGRIGHTDIMENSIONS.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
        public Vector2 SpriteDimensions
        {
            get { return EnemySpriteConstants.GOOMBAWALKINGRIGHTDIMENSIONS; }
        }
    }
}
