﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Collections;
using Game.Interfaces;

namespace Game.Mario.MarioSprites
{
    public class NormalLeftRunningMarioSprite : IMarioSprite
    {
        private int toggle;
        private Texture2D spriteSheet;
        private ArrayList normalLeftRunningSpriteDimensions;
        private ArrayList normalLeftRunningSpriteLocations;
        private int currentSprite;

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

            firstNormalLeftRunningSpriteDimensions.X = 16;
            firstNormalLeftRunningSpriteDimensions.Y = 31;

            secondNormalLeftRunningSpriteDimensions.X = 16;
            secondNormalLeftRunningSpriteDimensions.Y = 30;

            thirdNormalLeftRunningSpriteDimensions.X = 16;
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
