using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities.Constants;

namespace Game.Enemies.GoombaClasses.GoombaSprites
{
    class GoombaWalkingLeftSprite : ISprite
    {
        private Texture2D spriteSheet;
        private int currentFrame;

        public GoombaWalkingLeftSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {
                currentFrame++;
                if (currentFrame == EnemySpriteConstants.TOTALGOOMBAWALKINGFRAMES){
                    currentFrame = EnemySpriteConstants.RESETTOZERO;
                }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)EnemySpriteConstants.GOOMBAWALKINGLEFTFRAMES[currentFrame].X, (int)EnemySpriteConstants.GOOMBAWALKINGLEFTFRAMES[currentFrame].Y,
                (int)EnemySpriteConstants.GOOMBAWALKINGLEFTDIMENSIONS.X, (int)EnemySpriteConstants.GOOMBAWALKINGLEFTDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)EnemySpriteConstants.GOOMBAWALKINGLEFTDIMENSIONS.X, (int)EnemySpriteConstants.GOOMBAWALKINGLEFTDIMENSIONS.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return EnemySpriteConstants.GOOMBAWALKINGLEFTDIMENSIONS; }
        }
    }
}
