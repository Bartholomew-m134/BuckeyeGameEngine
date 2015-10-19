using System;
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
    public class SmallLeftRunningMarioSprite : IMarioSprite
    {
        private int toggle;
        private Texture2D spriteSheet;
        private ArrayList smallLeftRunningSpriteDimensions;
        private ArrayList smallLeftRunningSpriteLocations;
        private int currentSprite;
        private Vector2 currentDimensions;
        private Vector2 currentLocation;

        private Vector2 firstSmallLeftRunningSpriteLocation;
        private Vector2 secondSmallLeftRunningSpriteLocation;
        private Vector2 thirdSmallLeftRunningSpriteLocation;

        private Vector2 firstSmallLeftRunningSpriteDimensions;
        private Vector2 secondSmallLeftRunningSpriteDimensions;
        private Vector2 thirdSmallLeftRunningSpriteDimensions;

        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        public SmallLeftRunningMarioSprite(Texture2D spriteSheet)
        {
            toggle = 0;
            this.spriteSheet = spriteSheet;
            currentSprite = 0;
            smallLeftRunningSpriteDimensions = new ArrayList();
            smallLeftRunningSpriteLocations = new ArrayList();

            firstSmallLeftRunningSpriteDimensions.X = 13;
            firstSmallLeftRunningSpriteDimensions.Y = 14;

            secondSmallLeftRunningSpriteDimensions.X = 11;
            secondSmallLeftRunningSpriteDimensions.Y = 15;

            thirdSmallLeftRunningSpriteDimensions.X = 15;
            thirdSmallLeftRunningSpriteDimensions.Y = 15;

            firstSmallLeftRunningSpriteLocation.X = 150;
            firstSmallLeftRunningSpriteLocation.Y = 0;

            secondSmallLeftRunningSpriteLocation.X = 121;
            secondSmallLeftRunningSpriteLocation.Y = 0;

            thirdSmallLeftRunningSpriteLocation.X = 89;
            thirdSmallLeftRunningSpriteLocation.Y = 0;

            smallLeftRunningSpriteDimensions.Add(thirdSmallLeftRunningSpriteDimensions);     
            smallLeftRunningSpriteDimensions.Add(secondSmallLeftRunningSpriteDimensions);
            smallLeftRunningSpriteDimensions.Add(firstSmallLeftRunningSpriteDimensions);
            smallLeftRunningSpriteDimensions.Add(secondSmallLeftRunningSpriteDimensions);

            smallLeftRunningSpriteLocations.Add(firstSmallLeftRunningSpriteLocation);
            smallLeftRunningSpriteLocations.Add(secondSmallLeftRunningSpriteLocation);
            smallLeftRunningSpriteLocations.Add(thirdSmallLeftRunningSpriteLocation);
            smallLeftRunningSpriteLocations.Add(secondSmallLeftRunningSpriteLocation);
        }
        public void Update()
        {
                if (currentSprite < 3)
                {
                    currentDimensions = (Vector2)smallLeftRunningSpriteDimensions[currentSprite];
                    currentLocation = (Vector2)smallLeftRunningSpriteLocations[currentSprite];
                    currentSprite++;
                }
                else
                {
                    currentSprite = 0;
                    currentDimensions = (Vector2)smallLeftRunningSpriteDimensions[currentSprite];
                    currentLocation = (Vector2)smallLeftRunningSpriteLocations[currentSprite];
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
