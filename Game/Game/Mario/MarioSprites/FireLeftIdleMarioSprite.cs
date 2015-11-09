using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities.Constants;

namespace Game.Mario.MarioSprites
{
    public class FireLeftIdleMarioSprite : IMarioSprite
    {
        private Texture2D spriteSheet;
        private int starDrawCounter;
        private readonly Vector2 FIRELEFTIDLEWIDTHHEIGHT = new Vector2(16,31);
        private readonly Vector2 FIRELEFTIDLESOURCE = new Vector2(180, 122);
        public FireLeftIdleMarioSprite(Texture2D spriteSheet)
        {
            this.spriteSheet = spriteSheet;
            starDrawCounter = MarioSpriteConstants.RESETTOZERO;
        }
        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)FIRELEFTIDLESOURCE.X, (int)FIRELEFTIDLESOURCE.Y, 
                (int)FIRELEFTIDLEWIDTHHEIGHT.X, (int)FIRELEFTIDLEWIDTHHEIGHT.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 
                (int)FIRELEFTIDLEWIDTHHEIGHT.X, (int)FIRELEFTIDLEWIDTHHEIGHT.Y);
            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
        public void StarDraw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)FIRELEFTIDLESOURCE.X, (int)FIRELEFTIDLESOURCE.Y, 
                (int)FIRELEFTIDLEWIDTHHEIGHT.X, (int)FIRELEFTIDLEWIDTHHEIGHT.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 
                (int)FIRELEFTIDLEWIDTHHEIGHT.X, (int)FIRELEFTIDLEWIDTHHEIGHT.Y);

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
            get { return new Vector2((int)FIRELEFTIDLEWIDTHHEIGHT.X, (int)FIRELEFTIDLEWIDTHHEIGHT.Y); }
        }
    }
}
