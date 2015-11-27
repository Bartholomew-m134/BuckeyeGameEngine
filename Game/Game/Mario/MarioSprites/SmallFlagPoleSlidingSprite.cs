using Game.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;
using Game.Utilities;

namespace Game.Mario.MarioSprites
{
    class SmallFlagPoleSlidingSprite : IMarioSprite
    {
        private int starDrawCounter;
        private Texture2D spriteSheet;
        private Vector2 currentSourceLocation;
        private bool frameCounter;
        private int delayCounter;
        public SmallFlagPoleSlidingSprite(Texture2D spriteSheet)
        {
            frameCounter = false;
            this.spriteSheet = spriteSheet;
        }
        public void Update()
        {
            if (frameCounter ==false && delayCounter ==MarioSpriteConstants.FLAGUPDATEDELAYCOUNTER){
                currentSourceLocation = MarioSpriteConstants.FIRSTSMALLFLAGSOURCE;
                frameCounter = true;
                delayCounter = MarioSpriteConstants.RESETTOZERO;
            }
            else if (delayCounter == MarioSpriteConstants.FLAGUPDATEDELAYCOUNTER){
                currentSourceLocation = MarioSpriteConstants.SECONDSMALLFLAGSOURCE;
                frameCounter = false;
                delayCounter = MarioSpriteConstants.RESETTOZERO;
            }
            delayCounter++;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentSourceLocation.X, (int)currentSourceLocation.Y,
                (int)MarioSpriteConstants.SMALLFLAGMARIODIMENSIONS.X, (int)MarioSpriteConstants.SMALLFLAGMARIODIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)MarioSpriteConstants.SMALLFLAGMARIODIMENSIONS.X, (int)MarioSpriteConstants.SMALLFLAGMARIODIMENSIONS.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void StarDraw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentSourceLocation.X, (int)currentSourceLocation.Y,
                (int)MarioSpriteConstants.SMALLFLAGMARIODIMENSIONS.X, (int)MarioSpriteConstants.SMALLFLAGMARIODIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)MarioSpriteConstants.SMALLFLAGMARIODIMENSIONS.X, (int)MarioSpriteConstants.SMALLFLAGMARIODIMENSIONS.Y);

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
            get { return new Vector2((int)MarioSpriteConstants.SMALLFLAGMARIODIMENSIONS.X, (int)MarioSpriteConstants.SMALLFLAGMARIODIMENSIONS.Y); }
        }
    }
}
