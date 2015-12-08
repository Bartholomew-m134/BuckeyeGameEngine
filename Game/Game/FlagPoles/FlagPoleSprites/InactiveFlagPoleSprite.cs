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
    public class InactiveFlagPoleSprite : ISprite
    {
        private Texture2D Texture { get; set; }
        public InactiveFlagPoleSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)FlagPoleSpriteConstants.FIRSTFLAGFRAMECOORDINATES.X, (int)FlagPoleSpriteConstants.FIRSTFLAGFRAMECOORDINATES.Y, FlagPoleSpriteConstants.FLAGPOLEWIDTH, FlagPoleSpriteConstants.FLAGPOLEHEIGHT);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, FlagPoleSpriteConstants.FLAGPOLEWIDTH, FlagPoleSpriteConstants.FLAGPOLEHEIGHT);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2(FlagPoleSpriteConstants.FLAGPOLEWIDTH, FlagPoleSpriteConstants.FLAGPOLEHEIGHT); }
        }
    }
}
