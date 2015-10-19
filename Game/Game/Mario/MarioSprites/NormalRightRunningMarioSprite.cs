using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Collections;
using System.Diagnostics;
using Game.Interfaces;

namespace Game.Mario.MarioSprites
{
    public class NormalRightRunningMarioSprite : IMarioSprite
    {
        private int toggle;
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
            toggle = 0;
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

            normalRightRunningSpriteDimensions.Add(thirdNormalRightRunningSpriteDimensions);       
            normalRightRunningSpriteDimensions.Add(secondNormalRightRunningSpriteDimensions);
            normalRightRunningSpriteDimensions.Add(firstNormalRightRunningSpriteDimensions);
            normalRightRunningSpriteDimensions.Add(secondNormalRightRunningSpriteDimensions);

            normalRightRunningSpriteLocations.Add(thirdNormalRightRunningSpriteLocation);
            normalRightRunningSpriteLocations.Add(secondNormalRightRunningSpriteLocation);
            normalRightRunningSpriteLocations.Add(firstNormalRightRunningSpriteLocation);
            normalRightRunningSpriteLocations.Add(secondNormalRightRunningSpriteLocation);
        }
        public void Update()
        {
            if (delayBetweenFrames == 0)
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

        public void StarDraw(SpriteBatch spriteBatch, Vector2 location)
        {
            sourceRectangle = new Rectangle((int)currentLocation.X, (int)currentLocation.Y, (int)currentDimensions.X, (int)currentDimensions.Y);
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)currentDimensions.X, (int)currentDimensions.Y);

            if (toggle < 5)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.Brown);
                spriteBatch.End();
                toggle++;
            }

            else if (toggle > 6 && toggle < 10)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.YellowGreen);
                spriteBatch.End();
                toggle++;
            }

            else
            {
                spriteBatch.Begin();
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.Orange);
                spriteBatch.End();
                if (toggle < 15)
                {
                    toggle++;
                }
                else
                {
                    toggle = 0;
                }
            }

        }

        public Vector2 SpriteDimensions
        {
            get { return currentDimensions; }
        }
    }
}
