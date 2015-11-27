using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Collections;
using Game.Interfaces;
using Game.Utilities.Constants;
using Game.Utilities;

namespace Game.Mario.MarioSprites
{
    public class FireRightRunningMarioSprite : IMarioSprite
    {
        private int starDrawCounter;
        private Texture2D spriteSheet;
        private ArrayList fireRightRunningSpriteDimensions;
        private ArrayList fireRightRunningSpriteLocations;
        private int currentSprite;
        private Vector2 currentDimensions;
        private Vector2 currentLocation;
        public FireRightRunningMarioSprite(Texture2D spriteSheet)
        {
            this.spriteSheet = spriteSheet;
            currentSprite = MarioSpriteConstants.RESETTOZERO;
            fireRightRunningSpriteDimensions = new ArrayList();
            fireRightRunningSpriteLocations = new ArrayList();

            fireRightRunningSpriteDimensions.Add(MarioSpriteConstants.THIRDFIRERIGHTRUNNINGDIMENSIONS);
            fireRightRunningSpriteDimensions.Add(MarioSpriteConstants.SECONDFIRERIGHTRUNNINGDIMENSIONS);
            fireRightRunningSpriteDimensions.Add(MarioSpriteConstants.FIRSTFIRERIGHTRUNNINGDIMENSIONS);
            fireRightRunningSpriteDimensions.Add(MarioSpriteConstants.SECONDFIRERIGHTRUNNINGDIMENSIONS);

            fireRightRunningSpriteLocations.Add(MarioSpriteConstants.THIRDFIRERIGHTRUNNINGSOURCE);
            fireRightRunningSpriteLocations.Add(MarioSpriteConstants.SECONDFIRERIGHTRUNNINGSOURCE);
            fireRightRunningSpriteLocations.Add(MarioSpriteConstants.FIRSTFIRERIGHTRUNNINGSOURCE);
            fireRightRunningSpriteLocations.Add(MarioSpriteConstants.SECONDFIRERIGHTRUNNINGSOURCE);   
        }
        public void Update()
        {
                if (currentSprite < MarioSpriteConstants.RUNNINGUPDATEDELAY)
                {
                    currentDimensions = (Vector2)fireRightRunningSpriteDimensions[currentSprite];
                    currentLocation = (Vector2)fireRightRunningSpriteLocations[currentSprite];
                    currentSprite++;
                }
                else
                {
                    currentSprite = MarioSpriteConstants.RESETTOZERO;
                    currentDimensions = (Vector2)fireRightRunningSpriteDimensions[currentSprite];
                    currentLocation = (Vector2)fireRightRunningSpriteLocations[currentSprite];
                    currentSprite++;
                }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentLocation.X, (int)currentLocation.Y, (int)currentDimensions.X, (int)currentDimensions.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)currentDimensions.X, (int)currentDimensions.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void StarDraw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentLocation.X, (int)currentLocation.Y, (int)currentDimensions.X, (int)currentDimensions.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)currentDimensions.X, (int)currentDimensions.Y);

            if (starDrawCounter < MarioSpriteConstants.STARDRAWBROWNCOUNTER)
            {
                spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.Brown);
                spriteBatch.End();
                starDrawCounter++;
            }

            else if (starDrawCounter > MarioSpriteConstants.STARDRAWBROWNCOUNTER && starDrawCounter < MarioSpriteConstants.STARDRAWYELLOWGREENCOUNTER)
            {
                spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.YellowGreen);
                spriteBatch.End();
                starDrawCounter++;
            }

            else
            {
                spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.Orange);
                spriteBatch.End();
                if (starDrawCounter < MarioSpriteConstants.STARDRAWORANGECOUNTER)
                {
                    starDrawCounter++;
                }
                else
                {
                    starDrawCounter = MarioSpriteConstants.RESETTOZERO;
                }
            }
        }

        public Vector2 SpriteDimensions
        {
            get { return currentDimensions; }
        }
    }
}
