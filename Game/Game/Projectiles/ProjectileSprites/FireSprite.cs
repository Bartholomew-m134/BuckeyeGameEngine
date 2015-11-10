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

namespace Game.Projectiles.ProjectileSprites
{
    public class FireSprite : ISprite
    {
        private Texture2D texture;
        private int currentSprite;
        private Vector2 currentLocation;
        public FireSprite(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Update()
        {
            if (currentSprite < ProjectileSpriteConstants.UPDATEDELAY)
            {
                currentLocation = (Vector2)ProjectileSpriteConstants.FIRESOURCES[currentSprite];
                currentSprite++;
            }
            else
            {
                currentSprite = ProjectileSpriteConstants.RESETTOZERO;
                currentLocation = (Vector2)ProjectileSpriteConstants.FIRESOURCES[currentSprite];
                currentSprite++;
            }
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentLocation.X, (int)currentLocation.Y,
                (int)ProjectileSpriteConstants.FIREDIMENSIONS.X, (int)ProjectileSpriteConstants.FIREDIMENSIONS.X);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)ProjectileSpriteConstants.FIREDIMENSIONS.X, (int)ProjectileSpriteConstants.FIREDIMENSIONS.X);
            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
        public Vector2 SpriteDimensions
        {
            get { return ProjectileSpriteConstants.FIREDIMENSIONS; }
        }
    }
}
