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
    class GoombaSmashedSprite : ISprite
    {
        private Texture2D spriteSheet;
        private Rectangle sourceRectangle = new Rectangle((int)EnemySpriteConstants.GOOMBASMASHEDSOURCE.X, (int)(int)EnemySpriteConstants.GOOMBASMASHEDSOURCE.Y,
            (int)EnemySpriteConstants.GOOMBASMASHEDDIMENSIONS.X, (int)(int)EnemySpriteConstants.GOOMBASMASHEDDIMENSIONS.Y);

        public GoombaSmashedSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)EnemySpriteConstants.GOOMBASMASHEDDIMENSIONS.X, (int)(int)EnemySpriteConstants.GOOMBASMASHEDDIMENSIONS.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return EnemySpriteConstants.GOOMBASMASHEDDIMENSIONS; }
        }
    }
}
