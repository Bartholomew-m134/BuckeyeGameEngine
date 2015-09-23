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
    public class FireLeftRunningSprite : ISprite
    {
        private Game1 game;
        private Texture2D spriteSheet;
        private ArrayList fireLeftRunningSpriteDimensions;
        private ArrayList fireLeftRunningSpriteLocations;
        private int currentSprite;
        Vector2 currentDimensions;
        Vector2 currentLocation;

        Vector2 firstFireLeftRunningSpriteLocation;
        Vector2 secondFireLeftRunningSpriteLocation;
        Vector2 thirdFireLeftRunningSpriteLocation;
        Vector2 fourthFireLeftRunningSpriteLocation;

        Vector2 firstFireLeftRunningSpriteDimensions;
        Vector2 secondFireLeftRunningSpriteDimensions;
        Vector2 thirdFireLeftRunningSpriteDimensions;
        Vector2 fourthFireLeftRunningSpriteDimensions;

        Rectangle sourceRectangle;
        Rectangle destinationRectangle;

        public FireLeftRunningSprite(Texture2D spriteSheet, Game1 game)
        {
            this.game = game;
            this.spriteSheet = spriteSheet;
            currentSprite = 0;
            
            firstFireLeftRunningSpriteDimensions.X = 15;
            firstFireLeftRunningSpriteDimensions.Y = 31;

            secondFireLeftRunningSpriteDimensions.X = 13;
            secondFireLeftRunningSpriteDimensions.Y = 30;

            thirdFireLeftRunningSpriteDimensions.X = 15;
            thirdFireLeftRunningSpriteDimensions.Y = 29;

            fourthFireLeftRunningSpriteDimensions.X = 15;
            fourthFireLeftRunningSpriteDimensions.Y = 29;
 
            firstFireLeftRunningSpriteLocation.X = 152;
            firstFireLeftRunningSpriteLocation.Y = 153;

            secondFireLeftRunningSpriteLocation.X = 128;
            secondFireLeftRunningSpriteLocation.X = 152;

            thirdFireLeftRunningSpriteLocation.X = 102;
            thirdFireLeftRunningSpriteLocation.Y = 152;

            fourthFireLeftRunningSpriteLocation.X = 77;
            fourthFireLeftRunningSpriteLocation.Y = 152;
            
            fireLeftRunningSpriteDimensions.Add(firstFireLeftRunningSpriteDimensions);
            fireLeftRunningSpriteDimensions.Add(secondFireLeftRunningSpriteDimensions);
            fireLeftRunningSpriteDimensions.Add(thirdFireLeftRunningSpriteDimensions);
            fireLeftRunningSpriteDimensions.Add(fourthFireLeftRunningSpriteDimensions);

            fireLeftRunningSpriteLocations.Add(firstFireLeftRunningSpriteLocation);
            fireLeftRunningSpriteLocations.Add(secondFireLeftRunningSpriteLocation);
            fireLeftRunningSpriteLocations.Add(thirdFireLeftRunningSpriteLocation);
            fireLeftRunningSpriteLocations.Add(fourthFireLeftRunningSpriteLocation);
        }
        void Update()
        {
            if (currentSprite < 4)
            {
                currentDimensions=  (Vector2)fireLeftRunningSpriteDimensions[currentSprite];
                currentLocation = (Vector2)fireLeftRunningSpriteLocations[currentSprite];
                currentSprite++;
            }
        }

        void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            sourceRectangle = new Rectangle(sheetXLocation, sheetYLocation, width, height);
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
