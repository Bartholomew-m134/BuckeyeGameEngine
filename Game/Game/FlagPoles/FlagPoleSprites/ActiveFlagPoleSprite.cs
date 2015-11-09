using Game.Interfaces;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.FlagPoles.FlagPoleSprites
{
    public class ActiveFlagPoleSprite : ISprite
    {
        private Texture2D Texture { get; set; }
        private int delayCounter;

        private int currentSourceFrame;
        private Vector2 currentSourceCoordinates;
        public ActiveFlagPoleSprite(Texture2D texture)
        {
            Texture = texture;
            currentSourceCoordinates = FlagPoleSpriteConstants.FIRSTFLAGFRAMECOORDINATES;
            currentSourceFrame = FlagPoleSpriteConstants.RESETTOZERO;
            delayCounter = FlagPoleSpriteConstants.RESETTOZERO;

        }

        public void Update()
        {
            if(delayCounter == FlagPoleSpriteConstants.UPDATEDELAY){
                if (currentSourceFrame < FlagPoleSpriteConstants.NUMBEROFFRAMES)
                {
                    currentSourceCoordinates = (Vector2)FlagPoleSpriteConstants.FLAGPOLESOURCES[currentSourceFrame];
                    currentSourceFrame++;
                }
                delayCounter = FlagPoleSpriteConstants.RESETTOZERO;
            }
            delayCounter++;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)currentSourceCoordinates.X, (int)currentSourceCoordinates.Y, FlagPoleSpriteConstants.FLAGPOLEWIDTH, FlagPoleSpriteConstants.FLAGPOLEHEIGHT);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, FlagPoleSpriteConstants.FLAGPOLEWIDTH, FlagPoleSpriteConstants.FLAGPOLEHEIGHT);
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2(FlagPoleSpriteConstants.FLAGPOLEWIDTH, FlagPoleSpriteConstants.FLAGPOLEHEIGHT); }
        }
    }
}
