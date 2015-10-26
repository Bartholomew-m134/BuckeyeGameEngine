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
    public class FireRightRunningMarioSprite : IMarioSprite
    {
        private int toggle;
        private Texture2D spriteSheet;
        private ArrayList fireRightRunningSpriteDimensions;
        private ArrayList fireRightRunningSpriteLocations;
        private int currentSprite;
        private Vector2 currentDimensions;
        private Vector2 currentLocation;

        private Vector2 firstFireRightRunningSpriteLocation;
        private Vector2 secondFireRightRunningSpriteLocation;
        private Vector2 thirdFireRightRunningSpriteLocation;

        private Vector2 firstFireRightRunningSpriteDimensions;
        private Vector2 secondFireRightRunningSpriteDimensions;
        private Vector2 thirdFireRightRunningSpriteDimensions;

        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        public FireRightRunningMarioSprite(Texture2D spriteSheet)
        {
            toggle = 0;
            this.spriteSheet = spriteSheet;
            currentSprite = 0;
            fireRightRunningSpriteDimensions = new ArrayList();
            fireRightRunningSpriteLocations = new ArrayList();

            firstFireRightRunningSpriteDimensions.X = 16;
            firstFireRightRunningSpriteDimensions.Y = 31;

            secondFireRightRunningSpriteDimensions.X = 16;
            secondFireRightRunningSpriteDimensions.Y = 30;

            thirdFireRightRunningSpriteDimensions.X = 16;
            thirdFireRightRunningSpriteDimensions.Y = 29;

            firstFireRightRunningSpriteLocation.X = 237;
            firstFireRightRunningSpriteLocation.Y = 122;

            secondFireRightRunningSpriteLocation.X = 264;
            secondFireRightRunningSpriteLocation.Y = 122;

            thirdFireRightRunningSpriteLocation.X = 287;
            thirdFireRightRunningSpriteLocation.Y = 123;

            fireRightRunningSpriteDimensions.Add(thirdFireRightRunningSpriteDimensions);
            fireRightRunningSpriteDimensions.Add(secondFireRightRunningSpriteDimensions);
            fireRightRunningSpriteDimensions.Add(firstFireRightRunningSpriteDimensions);
            fireRightRunningSpriteDimensions.Add(secondFireRightRunningSpriteDimensions);

            fireRightRunningSpriteLocations.Add(thirdFireRightRunningSpriteLocation);
            fireRightRunningSpriteLocations.Add(secondFireRightRunningSpriteLocation);
            fireRightRunningSpriteLocations.Add(firstFireRightRunningSpriteLocation);
            fireRightRunningSpriteLocations.Add(secondFireRightRunningSpriteLocation);
            
        }
        public void Update()
        {
 
                if (currentSprite < 3)
                {
                    currentDimensions = (Vector2)fireRightRunningSpriteDimensions[currentSprite];
                    currentLocation = (Vector2)fireRightRunningSpriteLocations[currentSprite];
                    currentSprite++;
                }
                else
                {
                    currentSprite = 0;
                    currentDimensions = (Vector2)fireRightRunningSpriteDimensions[currentSprite];
                    currentLocation = (Vector2)fireRightRunningSpriteLocations[currentSprite];
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
