﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities.Constants;

namespace Game.Enemies.GoombaClasses.GoombaSprites
{
    class GoombaSmashedSprite : ISprite
    {
        private Texture2D spriteSheet;

        public GoombaSmashedSprite(Texture2D texture)
        {
            spriteSheet = texture;
        }

        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle((int)EnemySpriteConstants.GOOMBASMASHEDSOURCE.X, (int)(int)EnemySpriteConstants.GOOMBASMASHEDSOURCE.Y,
                (int)EnemySpriteConstants.GOOMBASMASHEDDIMENSIONS.X, (int)(int)EnemySpriteConstants.GOOMBASMASHEDDIMENSIONS.Y);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y,
                (int)EnemySpriteConstants.GOOMBASMASHEDDIMENSIONS.X, (int)(int)EnemySpriteConstants.GOOMBASMASHEDDIMENSIONS.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Vector2 SpriteDimensions
        {
            get { return EnemySpriteConstants.GOOMBASMASHEDDIMENSIONS; }
        }
    }
}
