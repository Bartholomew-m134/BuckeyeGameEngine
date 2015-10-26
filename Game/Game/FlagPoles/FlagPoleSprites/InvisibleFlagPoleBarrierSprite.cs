using Game.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.FlagPoles.FlagPoleSprites
{
    class InvisibleFlagPoleBarrierSprite : ISprite
    {
        private Texture2D Texture { get; set; }
        private int width;
        private int height;
        private int sourceX;
        private int sourceY;
        public InvisibleFlagPoleBarrierSprite(Texture2D texture)
        {
            Texture = texture;
            width = 16;
            height = 176;
            sourceX = 300;
            sourceY = 594;

        }

        public void Update() { 
        
        
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location) {
            
            

            Rectangle sourceRectangle = new Rectangle(sourceX, sourceY, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();

        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2(width, height); }
        }
    }
}
