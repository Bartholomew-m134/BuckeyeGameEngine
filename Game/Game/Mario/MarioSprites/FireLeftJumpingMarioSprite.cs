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
    public class FireLeftJumpingMarioSprite : IMarioSprite
    {
        private Texture2D spriteSheet;
        private int starDrawCounter;
        private readonly Vector2 FIRELEFTJUMPWIDTHHEIGHT = new Vector2(16,31);
        private readonly Vector2 FIRELEFTJUMPSOURCE = new Vector2(27,122);
        public FireLeftJumpingMarioSprite(Texture2D spriteSheet)
        {
            this.spriteSheet = spriteSheet;
            starDrawCounter = MarioSpriteConstants.RESETTOZERO;
        }
        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)FIRELEFTJUMPSOURCE.X, (int)FIRELEFTJUMPSOURCE.Y, 
                (int)FIRELEFTJUMPWIDTHHEIGHT.X, (int)FIRELEFTJUMPWIDTHHEIGHT.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 
                (int)FIRELEFTJUMPWIDTHHEIGHT.X, (int)FIRELEFTJUMPWIDTHHEIGHT.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
        public void StarDraw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)FIRELEFTJUMPSOURCE.X, (int)FIRELEFTJUMPSOURCE.Y, 
                (int)FIRELEFTJUMPWIDTHHEIGHT.X, (int)FIRELEFTJUMPWIDTHHEIGHT.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 
                (int)FIRELEFTJUMPWIDTHHEIGHT.X, (int)FIRELEFTJUMPWIDTHHEIGHT.Y);
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
            get { return new Vector2((int)FIRELEFTJUMPWIDTHHEIGHT.X, (int)FIRELEFTJUMPWIDTHHEIGHT.Y); }
        }
    }
}
