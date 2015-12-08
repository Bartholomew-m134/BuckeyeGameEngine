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
    class GreenKoopaHidingInShellSprite : ISprite
    {
        private Texture2D spriteSheet;
        public GreenKoopaHidingInShellSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)EnemySpriteConstants.KOOPAHIDINGSOURCE.X, (int)EnemySpriteConstants.KOOPAHIDINGSOURCE.Y,
                (int)EnemySpriteConstants.KOOPAHIDINGDIMENSIONS.X, (int)EnemySpriteConstants.KOOPAHIDINGDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
               (int)EnemySpriteConstants.KOOPAHIDINGDIMENSIONS.X, (int)EnemySpriteConstants.KOOPAHIDINGDIMENSIONS.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return EnemySpriteConstants.KOOPAHIDINGDIMENSIONS; }
        }
    }
}
