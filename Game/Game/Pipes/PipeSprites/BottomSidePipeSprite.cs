using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities.Constants;

namespace Game.Pipes.PipeSprites
{
    class BottomSidePipeSprite : ISprite
    {
        private Texture2D Texture { get; set; }

        public BottomSidePipeSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)PipeSpriteConstants.BOTTOMSIDEPIPESOURCE.X, (int)PipeSpriteConstants.BOTTOMSIDEPIPESOURCE.Y,
                (int)PipeSpriteConstants.BOTTOMSIDEPIPEDIMENSIONS.X, (int)PipeSpriteConstants.BOTTOMSIDEPIPEDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)PipeSpriteConstants.BOTTOMSIDEPIPEDIMENSIONS.X, (int)PipeSpriteConstants.BOTTOMSIDEPIPEDIMENSIONS.Y);
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)PipeSpriteConstants.BOTTOMSIDEPIPEDIMENSIONS.X, (int)PipeSpriteConstants.BOTTOMSIDEPIPEDIMENSIONS.Y); }
        }
    }
}