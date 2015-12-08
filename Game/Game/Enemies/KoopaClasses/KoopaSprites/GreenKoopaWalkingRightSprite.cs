using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities.Constants;
using Game.Utilities;

namespace Game.Enemies.KoopaClasses.GreenKoopaSprites
{
    class GreenKoopaWalkingRightSprite : ISprite
    {
        private Texture2D spriteSheet;
        private int currentFrame;

        public GreenKoopaWalkingRightSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {

                currentFrame++;
                if (currentFrame == EnemySpriteConstants.TOTALKOOPAWALKINGFRAMES)
                    currentFrame = EnemySpriteConstants.RESETTOZERO;

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)EnemySpriteConstants.KOOPAWALKINGRIGHTSOURCES[currentFrame].X, (int)EnemySpriteConstants.KOOPAWALKINGRIGHTSOURCES[currentFrame].Y,
                (int)EnemySpriteConstants.KOOPAWALKINGRIGHTDIMENSIONS[currentFrame].X, (int)EnemySpriteConstants.KOOPAWALKINGRIGHTDIMENSIONS[currentFrame].Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)EnemySpriteConstants.KOOPAWALKINGRIGHTDIMENSIONS[currentFrame].X, (int)EnemySpriteConstants.KOOPAWALKINGRIGHTDIMENSIONS[currentFrame].Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return EnemySpriteConstants.KOOPAWALKINGRIGHTDIMENSIONS[currentFrame]; }
        }
    }
}
