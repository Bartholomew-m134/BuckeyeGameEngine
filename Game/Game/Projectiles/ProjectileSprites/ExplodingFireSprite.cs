using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using System.Collections;

namespace Game.Projectiles.ProjectileSprites
{
    public class ExplodingFireSprite : ISprite
    {

        private Texture2D spriteSheet;
        private Vector2 spriteLocations;
        private Vector2 spriteDimensions;

        public ExplodingFireSprite(Texture2D texture)
        {
            spriteSheet = texture;

            spriteLocations.X = 419;
            spriteLocations.Y = 183;

            spriteDimensions.X = 16;
            spriteDimensions.Y = 16;
        }

        public void Update()
        {
            
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {

            Rectangle sourceRectangle = new Rectangle((int)spriteLocations.X, (int)spriteLocations.Y, (int)spriteDimensions.X, (int)spriteDimensions.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)spriteDimensions.X, (int)spriteDimensions.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();

        }

        public Vector2 SpriteDimensions
        {
            get { return spriteDimensions; }
        }

    }
}

