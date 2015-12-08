using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities.Constants;
using Game.Utilities;

namespace Game.Mario.MarioSprites
{
    public class FireLeftIdleMarioSprite : IMarioSprite
    {
        private Texture2D spriteSheet;
        private int starDrawCounter;
        public FireLeftIdleMarioSprite(Texture2D spriteSheet)
        {
            this.spriteSheet = spriteSheet;
        }
        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)MarioSpriteConstants.FIRELEFTIDLESOURCE.X, (int)MarioSpriteConstants.FIRELEFTIDLESOURCE.Y,
                (int)MarioSpriteConstants.FIRELEFTIDLEWIDTHHEIGHT.X, (int)MarioSpriteConstants.FIRELEFTIDLEWIDTHHEIGHT.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)MarioSpriteConstants.FIRELEFTIDLEWIDTHHEIGHT.X, (int)MarioSpriteConstants.FIRELEFTIDLEWIDTHHEIGHT.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
        public void StarDraw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)MarioSpriteConstants.FIRELEFTIDLESOURCE.X, (int)MarioSpriteConstants.FIRELEFTIDLESOURCE.Y,
                (int)MarioSpriteConstants.FIRELEFTIDLEWIDTHHEIGHT.X, (int)MarioSpriteConstants.FIRELEFTIDLEWIDTHHEIGHT.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)MarioSpriteConstants.FIRELEFTIDLEWIDTHHEIGHT.X, (int)MarioSpriteConstants.FIRELEFTIDLEWIDTHHEIGHT.Y);

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
            get { return new Vector2((int)MarioSpriteConstants.FIRELEFTIDLEWIDTHHEIGHT.X, (int)MarioSpriteConstants.FIRELEFTIDLEWIDTHHEIGHT.Y); }
        }
    }
}
