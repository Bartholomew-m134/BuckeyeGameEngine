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
    class GoombaFlippedSprite : ISprite
    {
        private Texture2D spriteSheet;
        public GoombaFlippedSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)EnemySpriteConstants.GOOMBAFLIPPEDSOURCE.X, (int)EnemySpriteConstants.GOOMBAFLIPPEDSOURCE.Y,
                (int)EnemySpriteConstants.GOOMBAFLIPPEDDIMENSIONS.X, (int)EnemySpriteConstants.GOOMBAFLIPPEDDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)EnemySpriteConstants.GOOMBAFLIPPEDDIMENSIONS.X, (int)EnemySpriteConstants.GOOMBAFLIPPEDDIMENSIONS.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.FlipVertically, 0);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return EnemySpriteConstants.GOOMBAFLIPPEDDIMENSIONS; }
        }
    }
}
