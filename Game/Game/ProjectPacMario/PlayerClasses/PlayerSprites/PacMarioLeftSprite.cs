using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectPacMario.PlayerClasses.PlayerSprites
{
    public class PacMarioLeftSprite : IMarioSprite
    {
        private Texture2D spriteSheet;
        private int starDrawCounter;
        private bool openOrClosed;
        private int updateDelay;
        private Vector2 currentSource;
        public PacMarioLeftSprite(Texture2D spriteSheet)
        {
            this.spriteSheet = spriteSheet;
            openOrClosed = true;
        }
        public void Update()
        {
            updateDelay++;
            if (updateDelay == MarioSpriteConstants.RUNNINGUPDATEDELAY && openOrClosed){
                updateDelay = MarioSpriteConstants.RESETTOZERO;
                openOrClosed = false;
                currentSource = PacMarioSpriteConstants.MOUTH_OPEN_LEFT_SOURCE;
            }
            else if (updateDelay == MarioSpriteConstants.RUNNINGUPDATEDELAY && !openOrClosed)
            {
                updateDelay = MarioSpriteConstants.RESETTOZERO;
                openOrClosed = true;
                currentSource = PacMarioSpriteConstants.MOUTH_CLOSED_LEFT_SOURCE;
            }
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentSource.X, (int)currentSource.Y,
                (int)PacMarioSpriteConstants.HORIZONTAL_DIMENSIONS.X, (int)PacMarioSpriteConstants.HORIZONTAL_DIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)PacMarioSpriteConstants.HORIZONTAL_DIMENSIONS.X, (int)PacMarioSpriteConstants.HORIZONTAL_DIMENSIONS.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, location, sourceRectangle, Color.White, 0f, Vector2.Zero, PacMarioSpriteConstants.PACMARIOSCALINGFACTOR, SpriteEffects.None, 0f);
            spriteBatch.End();
        }
        public void StarDraw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentSource.X, (int)currentSource.Y,
                (int)PacMarioSpriteConstants.HORIZONTAL_DIMENSIONS.X, (int)PacMarioSpriteConstants.HORIZONTAL_DIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)PacMarioSpriteConstants.HORIZONTAL_DIMENSIONS.X, (int)PacMarioSpriteConstants.HORIZONTAL_DIMENSIONS.Y);

            if (starDrawCounter < MarioSpriteConstants.STARDRAWBROWNCOUNTER)
            {
                spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
                spriteBatch.Draw(spriteSheet, location, sourceRectangle, Color.Brown, 0f, Vector2.Zero, PacMarioSpriteConstants.PACMARIOSCALINGFACTOR, SpriteEffects.None, 0f);
                spriteBatch.End();
                starDrawCounter++;
            }
            else if (starDrawCounter > MarioSpriteConstants.STARDRAWBROWNCOUNTER && starDrawCounter < MarioSpriteConstants.STARDRAWYELLOWGREENCOUNTER)
            {
                spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
                spriteBatch.Draw(spriteSheet, location, sourceRectangle, Color.YellowGreen, 0f, Vector2.Zero, PacMarioSpriteConstants.PACMARIOSCALINGFACTOR, SpriteEffects.None, 0f);
                spriteBatch.End();
                starDrawCounter++;
            }
            else
            {
                spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
                spriteBatch.Draw(spriteSheet, location, sourceRectangle, Color.Orange, 0f, Vector2.Zero, PacMarioSpriteConstants.PACMARIOSCALINGFACTOR, SpriteEffects.None, 0f);
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
            get { return new Vector2((int)PacMarioSpriteConstants.HORIZONTAL_DIMENSIONS.X, (int)PacMarioSpriteConstants.HORIZONTAL_DIMENSIONS.Y); }
        }
    }
}
