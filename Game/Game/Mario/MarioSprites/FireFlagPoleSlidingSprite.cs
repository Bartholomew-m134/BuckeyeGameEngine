using Game.Interfaces;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Mario.MarioSprites
{
    class FireFlagPoleSlidingSprite : IMarioSprite
    {
        private int starDrawCounter;
        private int delayCounter;
        private Texture2D spriteSheet;
        private Vector2 currentSourceLocation;
        private bool frameCounter;
        public FireFlagPoleSlidingSprite(Texture2D spriteSheet)
        {
            starDrawCounter = MarioSpriteConstants.RESETTOZERO;
            frameCounter = false;
            delayCounter = MarioSpriteConstants.RESETTOZERO;
            this.spriteSheet = spriteSheet;
            currentSourceLocation = MarioSpriteConstants.FIRSTFIREFLAGSOURCECOORDINATES;
        }
        public void Update()
        {
            if (frameCounter == false && delayCounter == MarioSpriteConstants.FLAGUPDATEDELAYCOUNTER)
            {
                currentSourceLocation = MarioSpriteConstants.FIRSTFIREFLAGSOURCECOORDINATES;
                frameCounter = true;
                delayCounter = MarioSpriteConstants.RESETTOZERO;
            }
            else if (delayCounter == MarioSpriteConstants.FLAGUPDATEDELAYCOUNTER)
            {
                currentSourceLocation = MarioSpriteConstants.SECONDFIREFLAGSOURCECOORDINATES;
                frameCounter = false;
                delayCounter = MarioSpriteConstants.RESETTOZERO;
            }
            delayCounter++;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentSourceLocation.X, (int)currentSourceLocation.Y,
                (int)MarioSpriteConstants.FIREFLAGMARIOWIDTHHEIGHT.X, (int)MarioSpriteConstants.FIREFLAGMARIOWIDTHHEIGHT.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)MarioSpriteConstants.FIREFLAGMARIOWIDTHHEIGHT.X, (int)MarioSpriteConstants.FIREFLAGMARIOWIDTHHEIGHT.Y);
            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void StarDraw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentSourceLocation.X, (int)currentSourceLocation.Y,
                (int)MarioSpriteConstants.FIREFLAGMARIOWIDTHHEIGHT.X, (int)MarioSpriteConstants.FIREFLAGMARIOWIDTHHEIGHT.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)MarioSpriteConstants.FIREFLAGMARIOWIDTHHEIGHT.X, (int)MarioSpriteConstants.FIREFLAGMARIOWIDTHHEIGHT.Y);
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
                    starDrawCounter++; 
                else
                    starDrawCounter = MarioSpriteConstants.RESETTOZERO;
            }
        }
        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)MarioSpriteConstants.FIREFLAGMARIOWIDTHHEIGHT.X, (int)MarioSpriteConstants.FIREFLAGMARIOWIDTHHEIGHT.Y); }
        }
    }
}
