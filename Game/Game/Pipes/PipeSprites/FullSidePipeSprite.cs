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
    class FullSidePipeSprite : ISprite
    {
        private Texture2D Texture { get; set; }

        public FullSidePipeSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)PipeSpriteConstants.FULLSIDEPIPESOURCE.X, (int)PipeSpriteConstants.FULLSIDEPIPESOURCE.Y,
                (int)PipeSpriteConstants.FULLSIDEPIPEDIMENSIONS.X, (int)PipeSpriteConstants.FULLSIDEPIPEDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)PipeSpriteConstants.FULLSIDEPIPEDIMENSIONS.X, (int)PipeSpriteConstants.FULLSIDEPIPEDIMENSIONS.Y);
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2((int)PipeSpriteConstants.FULLSIDEPIPEDIMENSIONS.X, (int)PipeSpriteConstants.FULLSIDEPIPEDIMENSIONS.Y); }
        }
    }
}