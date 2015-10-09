﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Collections;

namespace Game.Mario.MarioSprites
{
    public class NormalLeftRunningMarioSprite : ISprite
    {
        private int toggle;
        private Texture2D spriteSheet;
        private ArrayList normalLeftRunningSpriteDimensions;
        private ArrayList normalLeftRunningSpriteLocations;
        private int currentSprite;
        private int delayBetweenFrames = 0;

        private Vector2 currentDimensions;
        private Vector2 currentLocation;

        private Vector2 firstNormalLeftRunningSpriteLocation;
        private Vector2 secondNormalLeftRunningSpriteLocation;
        private Vector2 thirdNormalLeftRunningSpriteLocation;

        private Vector2 firstNormalLeftRunningSpriteDimensions;
        private Vector2 secondNormalLeftRunningSpriteDimensions;
        private Vector2 thirdNormalLeftRunningSpriteDimensions;

        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        public NormalLeftRunningMarioSprite(Texture2D spriteSheet)
        {
            toggle = 0;
            this.spriteSheet = spriteSheet;
            currentSprite = 0;
            normalLeftRunningSpriteDimensions = new ArrayList();
            normalLeftRunningSpriteLocations = new ArrayList();

            firstNormalLeftRunningSpriteDimensions.X = 15;
            firstNormalLeftRunningSpriteDimensions.Y = 31;

            secondNormalLeftRunningSpriteDimensions.X = 13;
            secondNormalLeftRunningSpriteDimensions.Y = 30;

            thirdNormalLeftRunningSpriteDimensions.X = 15;
            thirdNormalLeftRunningSpriteDimensions.Y = 29;

            firstNormalLeftRunningSpriteLocation.X = 150;
            firstNormalLeftRunningSpriteLocation.Y = 52;

            secondNormalLeftRunningSpriteLocation.X = 121;
            secondNormalLeftRunningSpriteLocation.Y = 52;

            thirdNormalLeftRunningSpriteLocation.X = 90;
            thirdNormalLeftRunningSpriteLocation.Y = 53;

            normalLeftRunningSpriteDimensions.Add(thirdNormalLeftRunningSpriteDimensions);
            normalLeftRunningSpriteDimensions.Add(secondNormalLeftRunningSpriteDimensions);
            normalLeftRunningSpriteDimensions.Add(firstNormalLeftRunningSpriteDimensions);
            normalLeftRunningSpriteDimensions.Add(secondNormalLeftRunningSpriteDimensions);

            normalLeftRunningSpriteLocations.Add(thirdNormalLeftRunningSpriteLocation);    
            normalLeftRunningSpriteLocations.Add(secondNormalLeftRunningSpriteLocation);
            normalLeftRunningSpriteLocations.Add(firstNormalLeftRunningSpriteLocation);
            normalLeftRunningSpriteLocations.Add(secondNormalLeftRunningSpriteLocation); 
        }
        public void Update()
        {
            if (delayBetweenFrames == 10)
            {
                delayBetweenFrames = 0;
                if (currentSprite < 3)
                {
                    currentDimensions = (Vector2)normalLeftRunningSpriteDimensions[currentSprite];
                    currentLocation = (Vector2)normalLeftRunningSpriteLocations[currentSprite];
                    currentSprite++;
                }
                else
                {
                    currentSprite = 0;
                    currentDimensions = (Vector2)normalLeftRunningSpriteDimensions[currentSprite];
                    currentLocation = (Vector2)normalLeftRunningSpriteLocations[currentSprite];
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

            if (toggle == 0)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
                spriteBatch.End();
                toggle = 1;
            }

            else
            {
                spriteBatch.Begin();
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.Yellow);
                spriteBatch.End();
                toggle = 0;
            }

        }

        public Vector2 SpriteDimensions
        {
            get { return currentDimensions; }
        }
    }
}
