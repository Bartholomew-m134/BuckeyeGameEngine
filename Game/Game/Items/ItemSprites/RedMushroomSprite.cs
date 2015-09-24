using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
namespace Game.Items.ItemSprites
{
    public class RedMushroomSprite: ISprite
    {
        private Texture2D Texture { get; set; }
        private int currentFrame;
        private int totalFrames;

        private Game1 myGame;
        public RedMushroomSprite(Texture2D texture, Game1 game)
        {
            Texture = texture;
            myGame = game;
            currentFrame = 1;
            totalFrames = 1;

        }

        public void Update() { 
        
        
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location) {
            int width = 17;
            int height = 17;
            int sourceX = 183;
            int sourceY = 33;
            

            Rectangle sourceRectangle = new Rectangle(sourceX, sourceY, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();

        }


    }
}
