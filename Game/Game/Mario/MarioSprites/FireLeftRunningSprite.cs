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
    public class FireLeftRunningSprite : ISprite
    {
        private Game1 game;
        private Texture2D spriteSheet;
        private ArrayList fireLeftRunningSpriteDimensions;
        private ArrayList fireLeftRunningSpriteLocations;
        private int currentSprite;
        private Vector2 currentDimensions;
        private Vector2 currentLocation;

        private Vector2 firstFireLeftRunningSpriteLocation;
        private Vector2 secondFireLeftRunningSpriteLocation;
        private Vector2 thirdFireLeftRunningSpriteLocation;

        private Vector2 firstFireLeftRunningSpriteDimensions;
        private Vector2 secondFireLeftRunningSpriteDimensions;
        private Vector2 thirdFireLeftRunningSpriteDimensions;

        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;

        public FireLeftRunningSprite(Texture2D spriteSheet, Game1 game)
        {
            this.game = game;
            this.spriteSheet = spriteSheet;
            currentSprite = 0;
            fireLeftRunningSpriteDimensions = new ArrayList();
            fireLeftRunningSpriteLocations = new ArrayList();
            
            firstFireLeftRunningSpriteDimensions.X = 15;
            firstFireLeftRunningSpriteDimensions.Y = 31;

            secondFireLeftRunningSpriteDimensions.X = 13;
            secondFireLeftRunningSpriteDimensions.Y = 30;

            thirdFireLeftRunningSpriteDimensions.X = 15;
            thirdFireLeftRunningSpriteDimensions.Y = 29;
 
            firstFireLeftRunningSpriteLocation.X = 152;
            firstFireLeftRunningSpriteLocation.Y = 122;

            secondFireLeftRunningSpriteLocation.X = 128;
            secondFireLeftRunningSpriteLocation.X = 122;

            thirdFireLeftRunningSpriteLocation.X = 102;
            thirdFireLeftRunningSpriteLocation.Y = 123;
            
            fireLeftRunningSpriteDimensions.Add(firstFireLeftRunningSpriteDimensions);
            fireLeftRunningSpriteDimensions.Add(secondFireLeftRunningSpriteDimensions);
            fireLeftRunningSpriteDimensions.Add(thirdFireLeftRunningSpriteDimensions);
            fireLeftRunningSpriteDimensions.Add(secondFireLeftRunningSpriteDimensions);

            fireLeftRunningSpriteLocations.Add(firstFireLeftRunningSpriteLocation);
            fireLeftRunningSpriteLocations.Add(secondFireLeftRunningSpriteLocation);
            fireLeftRunningSpriteLocations.Add(thirdFireLeftRunningSpriteLocation);
            fireLeftRunningSpriteLocations.Add(secondFireLeftRunningSpriteLocation);
        }
        public void Update()
        {
            if (currentSprite < 2)
            {
                currentDimensions=  (Vector2)fireLeftRunningSpriteDimensions[currentSprite];
                currentLocation = (Vector2)fireLeftRunningSpriteLocations[currentSprite];
                currentSprite++;
            }
            else
            {
                currentSprite = 0;
                currentDimensions = (Vector2)fireLeftRunningSpriteDimensions[currentSprite];
                currentLocation = (Vector2)fireLeftRunningSpriteLocations[currentSprite];
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
    }
}
