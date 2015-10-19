using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;

namespace Game.Enemies.KoopaClasses.GreenKoopaSprites
{
    class GreenKoopaWalkingRightSprite : ISprite
    {
        private Texture2D spriteSheet;
        private int currentFrame;
        private int totalFrames = 6;
        private Vector2[] spriteLocations;
        private Vector2[] spriteDimensions;

        public GreenKoopaWalkingRightSprite(Texture2D texture)
        {
            spriteSheet = texture;
            currentFrame = 0;
            spriteLocations = new Vector2[6];
            spriteDimensions = new Vector2[6];

            spriteLocations[0].X = 210;
            spriteLocations[0].Y = 2;

            spriteDimensions[0].X = 16;
            spriteDimensions[0].Y = 21;

            spriteLocations[1].X = 210;
            spriteLocations[1].Y = 2;

            spriteDimensions[1].X = 16;
            spriteDimensions[1].Y = 21;

            spriteLocations[2].X = 210;
            spriteLocations[2].Y = 2;

            spriteDimensions[2].X = 16;
            spriteDimensions[2].Y = 21;

            spriteLocations[3].X = 241;
            spriteLocations[3].Y = 2;

            spriteDimensions[3].X = 15;
            spriteDimensions[3].Y = 22;

            spriteLocations[4].X = 241;
            spriteLocations[4].Y = 2;

            spriteDimensions[4].X = 15;
            spriteDimensions[4].Y = 22;

            spriteLocations[5].X = 241;
            spriteLocations[5].Y = 2;

            spriteDimensions[5].X = 15;
            spriteDimensions[5].Y = 22;
        }

        public void Update()
        {

                currentFrame++;
                if (currentFrame == totalFrames)
                    currentFrame = 0;

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)spriteLocations[currentFrame].X, (int)spriteLocations[currentFrame].Y, (int)spriteDimensions[currentFrame].X, (int)spriteDimensions[currentFrame].Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)spriteDimensions[currentFrame].X, (int)spriteDimensions[currentFrame].Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return spriteDimensions[currentFrame]; }
        }
    }
}
