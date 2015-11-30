using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.FlagPoles.FlagPoleSprites
{
    public class InvisibleFlagPoleBarrierSprite : ISprite
    {
        private Texture2D Texture { get; set; }
        public InvisibleFlagPoleBarrierSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update() {      
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location) {
            Rectangle sourceRectangle = new Rectangle((int)FlagPoleSpriteConstants.FLAGPOLEBARRIERCOORDINATES.X, (int)FlagPoleSpriteConstants.FLAGPOLEBARRIERCOORDINATES.Y, FlagPoleSpriteConstants.FLAGPOLEBARRIERWIDTH, FlagPoleSpriteConstants.FLAGPOLEBARRIERHEIGHT);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, FlagPoleSpriteConstants.FLAGPOLEBARRIERWIDTH, FlagPoleSpriteConstants.FLAGPOLEBARRIERHEIGHT);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2(FlagPoleSpriteConstants.FLAGPOLEBARRIERWIDTH, FlagPoleSpriteConstants.FLAGPOLEBARRIERHEIGHT); }
        }
    }
}
