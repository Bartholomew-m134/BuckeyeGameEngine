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
    class GreenKoopaEmergingFromShellSprite : ISprite
    {
        private Texture2D spriteSheet;
        private int currentFrame;

        public GreenKoopaEmergingFromShellSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == Utilities.Constants.EnemySpriteConstants.TOTALKOOPAEMERGINGFRAMES)
                currentFrame = Utilities.Constants.EnemySpriteConstants.RESETTOZERO;

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)EnemySpriteConstants.KOOPAEMERGINGFRAMES[currentFrame].X, (int)EnemySpriteConstants.KOOPAEMERGINGFRAMES[currentFrame].Y, (int)EnemySpriteConstants.KOOPAEMERGINGDIMENSIONS[currentFrame].X, (int)EnemySpriteConstants.KOOPAEMERGINGDIMENSIONS[currentFrame].Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)EnemySpriteConstants.KOOPAEMERGINGDIMENSIONS[currentFrame].X, (int)EnemySpriteConstants.KOOPAEMERGINGDIMENSIONS[currentFrame].Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return Utilities.Constants.EnemySpriteConstants.KOOPAEMERGINGDIMENSIONS[currentFrame]; }
        }
    }
}

