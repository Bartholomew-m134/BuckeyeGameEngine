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

namespace Game.Lemming.Elevators
{
    class ElevatorSprite : ISprite
    {
        private Texture2D Texture { get; set; }

        public ElevatorSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)LemmingSpriteConstants.ELEVATORSOURCE.X, (int)LemmingSpriteConstants.ELEVATORSOURCE.Y,
                (int)LemmingSpriteConstants.ELEVATORDIMENSIONS.X, (int)LemmingSpriteConstants.ELEVATORDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)LemmingSpriteConstants.ELEVATORDIMENSIONS.X, (int)LemmingSpriteConstants.ELEVATORDIMENSIONS.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)LemmingSpriteConstants.ELEVATORDIMENSIONS.X, (int)LemmingSpriteConstants.ELEVATORDIMENSIONS.Y); }
        }
    }
}