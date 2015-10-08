using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Collections;

namespace Game.Mario.MarioSprites
{
    public class NormalRightRunningMarioSprite : ISprite
    {
        private Texture2D spriteSheet;
        private ArrayList normalRightRunningSpriteDimensions;
        private ArrayList normalRightRunningSpriteLocations;
        private int currentSprite;
        private int delayBetweenFrames = 0;
        private Vector2 currentDimensions;
        private Vector2 currentLocation;

        private Vector2 firstNormalRightRunningSpriteLocation;
        private Vector2 secondNormalRightRunningSpriteLocation;
        private Vector2 thirdNormalRightRunningSpriteLocation;

        private Vector2 firstNormalRightRunningSpriteDimensions;
        private Vector2 secondNormalRightRunningSpriteDimensions;
        private Vector2 thirdNormalRightRunningSpriteDimensions;

        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        public NormalRightRunningMarioSprite(Texture2D spriteSheet)
        {
            this.spriteSheet = spriteSheet;
            currentSprite = 0;
            normalRightRunningSpriteDimensions = new ArrayList();
            normalRightRunningSpriteLocations = new ArrayList();

            firstNormalRightRunningSpriteDimensions.X = 15;
            firstNormalRightRunningSpriteDimensions.Y = 31;

            secondNormalRightRunningSpriteDimensions.X = 13;
            secondNormalRightRunningSpriteDimensions.Y = 30;

            thirdNormalRightRunningSpriteDimensions.X = 15;
            thirdNormalRightRunningSpriteDimensions.Y = 29;

            firstNormalRightRunningSpriteLocation.X = 239;
            firstNormalRightRunningSpriteLocation.Y = 52;

            secondNormalRightRunningSpriteLocation.X = 270;
            secondNormalRightRunningSpriteLocation.Y = 52;

            thirdNormalRightRunningSpriteLocation.X = 299;
            thirdNormalRightRunningSpriteLocation.Y = 53;

            normalRightRunningSpriteDimensions.Add(firstNormalRightRunningSpriteDimensions);
            normalRightRunningSpriteDimensions.Add(secondNormalRightRunningSpriteDimensions);
            normalRightRunningSpriteDimensions.Add(thirdNormalRightRunningSpriteDimensions);
            normalRightRunningSpriteDimensions.Add(secondNormalRightRunningSpriteDimensions);

            normalRightRunningSpriteLocations.Add(firstNormalRightRunningSpriteLocation);
            normalRightRunningSpriteLocations.Add(secondNormalRightRunningSpriteLocation);
            normalRightRunningSpriteLocations.Add(thirdNormalRightRunningSpriteLocation);
            normalRightRunningSpriteLocations.Add(secondNormalRightRunningSpriteLocation);
        }
        public void Update()
        {
            if (delayBetweenFrames == 10)
            {
                delayBetweenFrames = 0;
                if (currentSprite < 3)
                {
                    currentDimensions = (Vector2)normalRightRunningSpriteDimensions[currentSprite];
                    currentLocation = (Vector2)normalRightRunningSpriteLocations[currentSprite];
                    currentSprite++;
                }
                else
                {
                    currentSprite = 0;
                    currentDimensions = (Vector2)normalRightRunningSpriteDimensions[currentSprite];
                    currentLocation = (Vector2)normalRightRunningSpriteLocations[currentSprite];
                    currentSprite++;
                }
            }
            else
            {
                delayBetweenFrames++;
            }


        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            sourceRectangle = new Rectangle((int)currentLocation.X, (int)currentLocation.Y, (int)currentDimensions.X, (int)currentDimensions.Y);
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)currentDimensions.X, (int)currentDimensions.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return currentDimensions; }
        }
    }
}
