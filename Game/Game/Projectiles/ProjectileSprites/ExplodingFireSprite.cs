using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using System.Collections;
using Game.Utilities.Constants;
using Game.Utilities;

namespace Game.Projectiles.ProjectileSprites
{
    public class ExplodingFireSprite : ISprite
    {
        private Texture2D spriteSheet;
        public ExplodingFireSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {    
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)ProjectileSpriteConstants.EXPLODINGFIRESOURCE.X, (int)ProjectileSpriteConstants.EXPLODINGFIRESOURCE.Y,
                (int)ProjectileSpriteConstants.EXPLODINGFIREDIMENSIONS.X, (int)ProjectileSpriteConstants.EXPLODINGFIREDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)ProjectileSpriteConstants.EXPLODINGFIREDIMENSIONS.X, (int)ProjectileSpriteConstants.EXPLODINGFIREDIMENSIONS.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();

        }

        public Vector2 SpriteDimensions
        {
            get { return ProjectileSpriteConstants.EXPLODINGFIREDIMENSIONS; }
        }

    }
}

