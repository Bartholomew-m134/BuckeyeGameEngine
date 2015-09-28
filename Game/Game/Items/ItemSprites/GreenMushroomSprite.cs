﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Items.ItemSprites
{
    public class GreenMushroomSprite: ISprite
    {
        private Texture2D Texture { get; set; }
        private int currentFrame;
        private int totalFrames;
        private Game1 myGame;
        private int width = 17;
        private int height = 17;
        private int sourceX = 213;
        private int sourceY = 33;

        public GreenMushroomSprite(Texture2D texture, Game1 game)
        {
            Texture = texture;
            myGame = game;
            currentFrame = 1;
            totalFrames = 1;

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
        

    }
}
