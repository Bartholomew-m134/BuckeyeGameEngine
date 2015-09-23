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

        Vector2 firstFireLeftRunningSpriteLocation;
        Vector2 secondFireLeftRunningSpriteLocation;
        Vector2 thirdFireLeftRunningSpriteLocation;
        Vector2 fourthFireLeftRunningSpriteLocation;

        Vector2 firstFireLeftRunningSpriteDimensions;
        Vector2 secondFireLeftRunningSpriteDimensions;
        Vector2 thirdFireLeftRunningSpriteDimensions;
        Vector2 fourthFireLeftRunningSpriteDimensions;

        public FireLeftRunningSprite(Texture2D spriteSheet, Game1 game)
        {
            this.game = game;
            this.spriteSheet = spriteSheet;
            //width, height to fill in
            firstFireLeftRunningSpriteDimensions = ();
            secondFireLeftRunningSpriteDimensions = ();
            thirdFireLeftRunningSpriteDimensions = ();
            fourthFireLeftRunningSpriteDimensions = ();
            //x,y locations on sheet to fill in
            firstFireLeftRunningSpriteLocation = ();
            secondFireLeftRunningSpriteLocation = ();
            thirdFireLeftRunningSpriteLocation = ();
            fourthFireLeftRunningSpriteLocation = ();
            
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

        }

        void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(sheetXLocation, sheetYLocation, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(spriteSheet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
