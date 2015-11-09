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
using Game.Utilities.Constants;

namespace Game.Mario.MarioSprites
{
    public class NormalRightRunningMarioSprite : IMarioSprite
    {
        private int starDrawCounter;
        private Texture2D spriteSheet;
        private ArrayList normalRightRunningSpriteDimensions;
        private ArrayList normalRightRunningSpriteLocations;
        private int currentSprite;
        private Vector2 currentDimensions;
        private Vector2 currentLocation;
        public NormalRightRunningMarioSprite(Texture2D spriteSheet)
        {
            this.spriteSheet = spriteSheet;
            normalRightRunningSpriteDimensions = new ArrayList();
            normalRightRunningSpriteLocations = new ArrayList();

            normalRightRunningSpriteDimensions.Add(MarioSpriteConstants.THIRDNORMALRIGHTRUNNINGDIMENSIONS);
            normalRightRunningSpriteDimensions.Add(MarioSpriteConstants.SECONDNORMALRIGHTRUNNINGDIMENSIONS);
            normalRightRunningSpriteDimensions.Add(MarioSpriteConstants.FIRSTNORMALRIGHTRUNNINGDIMENSIONS);
            normalRightRunningSpriteDimensions.Add(MarioSpriteConstants.SECONDNORMALRIGHTRUNNINGDIMENSIONS);

            normalRightRunningSpriteLocations.Add(MarioSpriteConstants.THIRDNORMALRIGHTRUNNINGSOURCE);
            normalRightRunningSpriteLocations.Add(MarioSpriteConstants.SECONDNORMALRIGHTRUNNINGSOURCE);
            normalRightRunningSpriteLocations.Add(MarioSpriteConstants.FIRSTNORMALRIGHTRUNNINGSOURCE);
            normalRightRunningSpriteLocations.Add(MarioSpriteConstants.SECONDNORMALRIGHTRUNNINGSOURCE);
        }
        public void Update()
        {

                if (currentSprite < MarioSpriteConstants.RUNNINGUPDATEDELAY)
                {
                    currentDimensions = (Vector2)normalRightRunningSpriteDimensions[currentSprite];
                    currentLocation = (Vector2)normalRightRunningSpriteLocations[currentSprite];
                    currentSprite++;
                }
                else
                {
                    currentSprite = MarioSpriteConstants.RESETTOZERO;
                    currentDimensions = (Vector2)normalRightRunningSpriteDimensions[currentSprite];
                    currentLocation = (Vector2)normalRightRunningSpriteLocations[currentSprite];
                    currentSprite++;
                }


        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentLocation.X, (int)currentLocation.Y, (int)currentDimensions.X, (int)currentDimensions.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)currentDimensions.X, (int)currentDimensions.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void StarDraw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentLocation.X, (int)currentLocation.Y, (int)currentDimensions.X, (int)currentDimensions.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)currentDimensions.X, (int)currentDimensions.Y);

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
