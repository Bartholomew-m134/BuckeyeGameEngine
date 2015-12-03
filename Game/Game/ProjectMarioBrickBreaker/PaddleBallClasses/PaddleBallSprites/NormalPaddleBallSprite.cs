using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectMarioBrickBreaker.PaddleBallClasses.PaddleBallSprites
{
    public class NormalPaddleBallSprite : ISprite
    {
        private Texture2D Texture { get; set; }

        public NormalPaddleBallSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)PaddleBallConstants.NORMALPADDLEBALLSOURCE.X, (int)PaddleBallConstants.NORMALPADDLEBALLSOURCE.Y,
                (int)PaddleBallConstants.NORMALPADDLEBALLDIMENSIONS.X, (int)PaddleBallConstants.NORMALPADDLEBALLDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)PaddleBallConstants.NORMALPADDLEBALLDIMENSIONS.X, (int)PaddleBallConstants.NORMALPADDLEBALLDIMENSIONS.Y);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)PaddleBallConstants.NORMALPADDLEBALLDIMENSIONS.X, (int)PaddleBallConstants.NORMALPADDLEBALLDIMENSIONS.Y); }
        }
    }
}
