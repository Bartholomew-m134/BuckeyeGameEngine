﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Enemies.GreenKoopaClasses.GreenKoopaSprites
{
    class GreenKoopaWalkingRightSprite
    {
        private Game1 myGame;
        private Texture2D spriteSheet;
        private int currentFrame;
        private int totalFrames = 2;
        private int delayBetweenFrames = 0;

        public GreenKoopaWalkingRightSprite(Texture2D texture, Game1 game)
        {
            spriteSheet = texture;
            myGame = game;
        }

        public void Update()
        {
            if (delayBetweenFrames == 10)
            {
                delayBetweenFrames = 0;
                currentFrame++;
                if (currentFrame == totalFrames)
                    currentFrame = 0;
            }
            else
            {
                delayBetweenFrames++;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (currentFrame == 0)
            {
                Rectangle sourceRectangle = new Rectangle(210, 2, 16, 21);
                Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 21);

                spriteBatch.Begin();
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
                spriteBatch.End();
            }
            else if (currentFrame == 1)
            {
                Rectangle sourceRectangle = new Rectangle(241, 2, 15, 22);
                Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 15, 22);

                spriteBatch.Begin();
                spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
                spriteBatch.End();
            }
    }
}
