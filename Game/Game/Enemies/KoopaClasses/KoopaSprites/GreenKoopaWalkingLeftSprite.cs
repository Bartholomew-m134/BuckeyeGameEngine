using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities.Constants;

namespace Game.Enemies.KoopaClasses.GreenKoopaSprites
{
    class GreenKoopaWalkingLeftSprite : ISprite
    {
        private Texture2D spriteSheet;
        private int currentFrame;
        public GreenKoopaWalkingLeftSprite(Texture2D texture)
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
            Rectangle sourceRectangle = new Rectangle((int)EnemySpriteConstants.KOOPAWALKINGLEFTSOURCES[currentFrame].X, (int)EnemySpriteConstants.KOOPAWALKINGLEFTSOURCES[currentFrame].Y,
                (int)EnemySpriteConstants.KOOPAWALKINGLEFTDIMENSIONS[currentFrame].X, (int)EnemySpriteConstants.KOOPAWALKINGLEFTDIMENSIONS[currentFrame].Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)EnemySpriteConstants.KOOPAWALKINGLEFTDIMENSIONS[currentFrame].X, (int)EnemySpriteConstants.KOOPAWALKINGLEFTDIMENSIONS[currentFrame].Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return EnemySpriteConstants.KOOPAWALKINGLEFTDIMENSIONS[currentFrame]; }
        }
    }
}
