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
    public class FireRightRunningSprite : ISprite
    {
        private Game1 game;
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
        public FireRightRunningSprite(Texture2D spriteSheet, Game1 game)
        {
            this.game = game;
            this.spriteSheet = spriteSheet;
            currentSprite = 0;

            firstFireRightRunningSpriteDimensions.X = 15;
            firstFireRightRunningSpriteDimensions.Y = 31;

            secondFireRightRunningSpriteDimensions.X = 13;
            secondFireRightRunningSpriteDimensions.Y = 30;

            thirdFireRightRunningSpriteDimensions.X = 15;
            thirdFireRightRunningSpriteDimensions.Y = 29;

            firstFireRightRunningSpriteLocation.X = 237;
            firstFireRightRunningSpriteLocation.Y = 122;

            secondFireRightRunningSpriteLocation.X = 264;
            secondFireRightRunningSpriteLocation.X = 122;

            thirdFireRightRunningSpriteLocation.X = 287;
            thirdFireRightRunningSpriteLocation.Y = 123;

            fireRightRunningSpriteDimensions.Add(firstFireRightRunningSpriteDimensions);
            fireRightRunningSpriteDimensions.Add(secondFireRightRunningSpriteDimensions);
            fireRightRunningSpriteDimensions.Add(thirdFireRightRunningSpriteDimensions);
            fireRightRunningSpriteDimensions.Add(secondFireRightRunningSpriteDimensions);

            fireRightRunningSpriteLocations.Add(firstFireRightRunningSpriteLocation);
            fireRightRunningSpriteLocations.Add(secondFireRightRunningSpriteLocation);
            fireRightRunningSpriteLocations.Add(thirdFireRightRunningSpriteLocation);
            fireRightRunningSpriteLocations.Add(secondFireRightRunningSpriteLocation); 
        }
        void Update()
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

        void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            sourceRectangle = new Rectangle((int)currentLocation.X, (int)currentLocation.Y, (int)currentDimensions.X, (int)currentDimensions.Y);
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)currentDimensions.X, (int)currentDimensions.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
