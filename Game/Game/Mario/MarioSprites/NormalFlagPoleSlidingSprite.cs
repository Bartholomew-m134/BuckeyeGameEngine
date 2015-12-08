using Game.Interfaces;
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
    class NormalFlagPoleSlidingSprite : IMarioSprite
    {
        private int starDrawCounter;
        private int delayCounter;
        private Texture2D spriteSheet;
        private Vector2 currentSourceLocation;
        private bool frameCounter;
        public NormalFlagPoleSlidingSprite(Texture2D spriteSheet)
        {
            frameCounter = false;
            this.spriteSheet = spriteSheet;
            currentSourceLocation = MarioSpriteConstants.FIRSTNORMALFLAGSOURCE;
        }
        public void Update()
        {
            if (frameCounter == false && delayCounter == MarioSpriteConstants.FLAGUPDATEDELAYCOUNTER)
            {
                currentSourceLocation = MarioSpriteConstants.FIRSTNORMALFLAGSOURCE;
                frameCounter = true;
                delayCounter = MarioSpriteConstants.RESETTOZERO;
            }
            else if (delayCounter == MarioSpriteConstants.FLAGUPDATEDELAYCOUNTER)
            {
                currentSourceLocation = MarioSpriteConstants.SECONDNORMALFLAGSOURCE;
                delayCounter = MarioSpriteConstants.RESETTOZERO;
            }
            delayCounter++;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentSourceLocation.X, (int)currentSourceLocation.Y,
                (int)MarioSpriteConstants.NORMALFLAGMARIOWIDTHHEIGHT.X, (int)MarioSpriteConstants.NORMALFLAGMARIOWIDTHHEIGHT.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)MarioSpriteConstants.NORMALFLAGMARIOWIDTHHEIGHT.X, (int)MarioSpriteConstants.NORMALFLAGMARIOWIDTHHEIGHT.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void StarDraw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentSourceLocation.X, (int)currentSourceLocation.Y,
                (int)MarioSpriteConstants.NORMALFLAGMARIOWIDTHHEIGHT.X, (int)MarioSpriteConstants.NORMALFLAGMARIOWIDTHHEIGHT.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)MarioSpriteConstants.NORMALFLAGMARIOWIDTHHEIGHT.X, (int)MarioSpriteConstants.NORMALFLAGMARIOWIDTHHEIGHT.Y);

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
            get { return new Vector2((int)MarioSpriteConstants.NORMALFLAGMARIOWIDTHHEIGHT.X, (int)MarioSpriteConstants.NORMALFLAGMARIOWIDTHHEIGHT.Y); }
        }
    }
}
