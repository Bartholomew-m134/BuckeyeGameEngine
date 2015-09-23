using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Collections;

namespace Game.Mario.MarioSprites
{
    public class SmallRightRunningSprite : ISprite
    {
        private Game1 game;
        private Texture2D spriteSheet;
        private ArrayList smallRightRunningSpriteDimensions;
        private ArrayList smallRightRunningSpriteLocations;
        private int currentSprite;
        private Vector2 currentDimensions;
        private Vector2 currentLocation;

        private Vector2 firstSmallRightRunningSpriteLocation;
        private Vector2 secondSmallRightRunningSpriteLocation;
        private Vector2 thirdSmallRightRunningSpriteLocation;

        private Vector2 firstSmallRightRunningSpriteDimensions;
        private Vector2 secondSmallRightRunningSpriteDimensions;
        private Vector2 thirdSmallRightRunningSpriteDimensions;

        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        public SmallRightRunningSprite(Texture2D spriteSheet, Game1 game)
        {
            this.game = game;
            this.spriteSheet = spriteSheet;
            currentSprite = 0;

            firstSmallRightRunningSpriteDimensions.X = 13;
            firstSmallRightRunningSpriteDimensions.Y = 14;

            secondSmallRightRunningSpriteDimensions.X = 11;
            secondSmallRightRunningSpriteDimensions.Y = 15;

            thirdSmallRightRunningSpriteDimensions.X = 15;
            thirdSmallRightRunningSpriteDimensions.Y = 15;

            firstSmallRightRunningSpriteLocation.X = 241;
            firstSmallRightRunningSpriteLocation.Y = 0;

            secondSmallRightRunningSpriteLocation.X = 272;
            secondSmallRightRunningSpriteLocation.X = 0;

            thirdSmallRightRunningSpriteLocation.X = 300;
            thirdSmallRightRunningSpriteLocation.Y = 0;

            smallRightRunningSpriteDimensions.Add(firstSmallRightRunningSpriteDimensions);
            smallRightRunningSpriteDimensions.Add(secondSmallRightRunningSpriteDimensions);
            smallRightRunningSpriteDimensions.Add(thirdSmallRightRunningSpriteDimensions);
            smallRightRunningSpriteDimensions.Add(secondSmallRightRunningSpriteDimensions);

            smallRightRunningSpriteLocations.Add(firstSmallRightRunningSpriteLocation);
            smallRightRunningSpriteLocations.Add(secondSmallRightRunningSpriteLocation);
            smallRightRunningSpriteLocations.Add(thirdSmallRightRunningSpriteLocation);
            smallRightRunningSpriteLocations.Add(secondSmallRightRunningSpriteLocation);
        }
        void Update()
        {
            if (currentSprite < 3)
            {
                currentDimensions = (Vector2)smallRightRunningSpriteDimensions[currentSprite];
                currentLocation = (Vector2)smallRightRunningSpriteLocations[currentSprite];
                currentSprite++;
            }
            else
            {
                currentSprite = 0;
                currentDimensions = (Vector2)smallRightRunningSpriteDimensions[currentSprite];
                currentLocation = (Vector2)smallRightRunningSpriteLocations[currentSprite];
                currentSprite++;
            }
        }

        void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            sourceRectangle = new Rectangle((int)currentLocation.X, (int)currentLocation.Y, (int)currentDimensions.X, (int)currentDimensions.Y);
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)currentDimensions.X, (int)currentDimensions.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
