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

namespace Game.Mario.MarioSprites
{
    public class FireLeftRunningMarioSprite : IMarioSprite
    {
        private int starDrawCounter;
        private int currentSprite;
        private Texture2D spriteSheet;
        private ArrayList fireLeftRunningSpriteDimensions;
        private ArrayList fireLeftRunningSpriteLocations;
        private Vector2 currentDimensions;
        private Vector2 currentLocation;

        private readonly Vector2 FIRSTFIRELEFTRUNNINGSOURCE = new Vector2(152, 122);
        private readonly Vector2 SECONDFIRELEFTRUNNINGSOURCE = new Vector2(128, 122);
        private readonly Vector2 THIRDFIRELEFTRUNNINGSOURCE = new Vector2(102, 123);

        private readonly Vector2 FIRSTFIRELEFTRUNNINGDIMENSIONS = new Vector2(16,31);
        private readonly Vector2 SECONDFIRELEFTRUNNINGDIMENSIONS = new Vector2(16, 31);
        private readonly Vector2 THIRDFIRELEFTRUNNINGDIMENSIONS = new Vector2(16, 29);

        public FireLeftRunningMarioSprite(Texture2D spriteSheet)
        {
            this.spriteSheet = spriteSheet;
            starDrawCounter = MarioSpriteConstants.RESETTOZERO;
            currentSprite = MarioSpriteConstants.RESETTOZERO;
            fireLeftRunningSpriteDimensions = new ArrayList();
            fireLeftRunningSpriteLocations = new ArrayList();

            fireLeftRunningSpriteDimensions.Add(THIRDFIRELEFTRUNNINGDIMENSIONS);
            fireLeftRunningSpriteDimensions.Add(SECONDFIRELEFTRUNNINGDIMENSIONS);
            fireLeftRunningSpriteDimensions.Add(FIRSTFIRELEFTRUNNINGDIMENSIONS);
            fireLeftRunningSpriteDimensions.Add(SECONDFIRELEFTRUNNINGDIMENSIONS);

            fireLeftRunningSpriteLocations.Add(THIRDFIRELEFTRUNNINGSOURCE);
            fireLeftRunningSpriteLocations.Add(SECONDFIRELEFTRUNNINGSOURCE);
            fireLeftRunningSpriteLocations.Add(FIRSTFIRELEFTRUNNINGSOURCE);
            fireLeftRunningSpriteLocations.Add(SECONDFIRELEFTRUNNINGSOURCE);
        }
        public void Update()
        {
                if (currentSprite < MarioSpriteConstants.RUNNINGUPDATEDELAY)
                {
                    currentDimensions = (Vector2)fireLeftRunningSpriteDimensions[currentSprite];
                    currentLocation = (Vector2)fireLeftRunningSpriteLocations[currentSprite];
                    currentSprite++;
                }
                else
                {
                    currentSprite = MarioSpriteConstants.RESETTOZERO;
                    currentDimensions = (Vector2)fireLeftRunningSpriteDimensions[currentSprite];
                    currentLocation = (Vector2)fireLeftRunningSpriteLocations[currentSprite];
                    currentSprite++;
                }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentLocation.X, (int)currentLocation.Y, 
                (int)currentDimensions.X, (int)currentDimensions.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 
                (int)currentDimensions.X, (int)currentDimensions.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void StarDraw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentLocation.X, (int)currentLocation.Y, 
                (int)currentDimensions.X, (int)currentDimensions.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 
                (int)currentDimensions.X, (int)currentDimensions.Y);

            if (starDrawCounter < MarioSpriteConstants.STARDRAWBROWNCOUNTER)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.Brown);
                spriteBatch.End();
                starDrawCounter++;
            }

            else if (starDrawCounter > MarioSpriteConstants.STARDRAWBROWNCOUNTER && starDrawCounter < MarioSpriteConstants.STARDRAWYELLOWGREENCOUNTER)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.YellowGreen);
                spriteBatch.End();
                starDrawCounter++;
            }
            else
            {
                spriteBatch.Begin();
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
