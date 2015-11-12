using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities.Constants;

namespace Game.ProjectBuckeye.PlayerClasses.BuckeyePlayerSprites
{
    public class BuckeyeRightIdleSprite : ISprite
    {
        private Texture2D spriteSheet;

        public BuckeyeRightIdleSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)BuckeyePlayerSpriteConstants.RIGHT_FRAME_1_SOURCE.X, (int)BuckeyePlayerSpriteConstants.RIGHT_FRAME_1_SOURCE.Y,
                (int)BuckeyePlayerSpriteConstants.RIGHT_FRAME_1_DIMENSIONS.X, (int)BuckeyePlayerSpriteConstants.RIGHT_FRAME_1_DIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)BuckeyePlayerSpriteConstants.RIGHT_FRAME_1_DIMENSIONS.X, (int)BuckeyePlayerSpriteConstants.RIGHT_FRAME_1_DIMENSIONS.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return BuckeyePlayerSpriteConstants.RIGHT_FRAME_1_DIMENSIONS; }
        }
    }
}
