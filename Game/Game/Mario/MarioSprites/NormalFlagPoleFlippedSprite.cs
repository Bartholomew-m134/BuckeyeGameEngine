﻿using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Mario.MarioSprites
{
    public class NormalFlagPoleFlippedSprite : IMarioSprite
    {
        private Texture2D spriteSheet;
        private int starDrawCounter;
        public NormalFlagPoleFlippedSprite(Texture2D spriteSheet)
        {
            this.spriteSheet = spriteSheet;
        }
        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)MarioSpriteConstants.NORMALFLAGFLIPPEDSOURCE.X, (int)MarioSpriteConstants.NORMALFLAGFLIPPEDSOURCE.Y,
                (int)MarioSpriteConstants.NORMALFLAGFLIPPEDDIMENSIONS.X, (int)MarioSpriteConstants.NORMALFLAGFLIPPEDDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)MarioSpriteConstants.NORMALFLAGFLIPPEDDIMENSIONS.X, (int)MarioSpriteConstants.NORMALFLAGFLIPPEDDIMENSIONS.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
        public void StarDraw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)MarioSpriteConstants.NORMALFLAGFLIPPEDSOURCE.X, (int)MarioSpriteConstants.NORMALFLAGFLIPPEDSOURCE.Y,
                (int)MarioSpriteConstants.NORMALFLAGFLIPPEDDIMENSIONS.X, (int)MarioSpriteConstants.NORMALFLAGFLIPPEDDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)MarioSpriteConstants.NORMALFLAGFLIPPEDDIMENSIONS.X, (int)MarioSpriteConstants.NORMALFLAGFLIPPEDDIMENSIONS.Y);
            if (starDrawCounter < MarioSpriteConstants.STARDRAWBROWNCOUNTER)
            {
                spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.Brown);
                spriteBatch.End();
                starDrawCounter++;
            }
            else if (starDrawCounter > MarioSpriteConstants.STARDRAWBROWNCOUNTER && starDrawCounter < MarioSpriteConstants.STARDRAWYELLOWGREENCOUNTER)
            {
                spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.YellowGreen);
                spriteBatch.End();
                starDrawCounter++;
            }
            else
            {
                spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.Orange);
                spriteBatch.End();
                if (starDrawCounter < MarioSpriteConstants.STARDRAWORANGECOUNTER)
                    starDrawCounter++;
                else
                    starDrawCounter = MarioSpriteConstants.RESETTOZERO;
            }
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)MarioSpriteConstants.NORMALFLAGFLIPPEDDIMENSIONS.X, (int)MarioSpriteConstants.NORMALFLAGFLIPPEDDIMENSIONS.Y); }
        }
    }
}