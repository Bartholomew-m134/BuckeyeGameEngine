using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectMarioBrickBreaker.PlayerClasses.PaddleSprites
{
    public class MushroomPaddleSprite : ISprite
    {
        private Texture2D Texture { get; set; }

        public MushroomPaddleSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)PaddleSpriteConstants.MUSHROOMPADDLESOURCE.X, (int)PaddleSpriteConstants.MUSHROOMPADDLESOURCE.Y,
                (int)PaddleSpriteConstants.MUSHROOMPADDLEDIMENSIONS.X, (int)PaddleSpriteConstants.MUSHROOMPADDLEDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)PaddleSpriteConstants.MUSHROOMPADDLEDIMENSIONS.X, (int)PaddleSpriteConstants.MUSHROOMPADDLEDIMENSIONS.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)PaddleSpriteConstants.MUSHROOMPADDLEDIMENSIONS.X, (int)PaddleSpriteConstants.MUSHROOMPADDLEDIMENSIONS.Y); }
        }
    }
}
