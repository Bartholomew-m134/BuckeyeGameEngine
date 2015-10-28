using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using System.Collections;

namespace Game.Projectiles.ProjectileSprites
{
    public class FireSprite : ISprite
    {

        private Texture2D texture;
        private ArrayList fireSpriteLocations;
        private int currentSprite;

        private Vector2 currentLocation;

        private Vector2 firstFireSpriteLocation;
        private Vector2 secondFireSpriteLocation;
        private Vector2 thirdFireSpriteLocation;
        private Vector2 fourthFireSpriteLocation;

        private Vector2 fireSpriteDimensions;

        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;

        public FireSprite(Texture2D texture)
        {
            this.texture = texture;
            currentSprite = 0;
            fireSpriteLocations = new ArrayList();

            fireSpriteDimensions.X = 8;
            fireSpriteDimensions.Y = 8;

            firstFireSpriteLocation.X = 41;
            firstFireSpriteLocation.Y = 150;

            secondFireSpriteLocation.X = 41;
            secondFireSpriteLocation.Y = 165;

            thirdFireSpriteLocation.X = 26;
            thirdFireSpriteLocation.Y = 150;

            fourthFireSpriteLocation.X = 26;
            fourthFireSpriteLocation.Y = 165;



            fireSpriteLocations.Add(thirdFireSpriteLocation);
            fireSpriteLocations.Add(secondFireSpriteLocation);
            fireSpriteLocations.Add(firstFireSpriteLocation);
            fireSpriteLocations.Add(fourthFireSpriteLocation);
        }

        public void Update()
        {
            if (currentSprite < 3)
            {
                currentLocation = (Vector2)fireSpriteLocations[currentSprite];
                currentSprite++;
            }
            else
            {
                currentSprite = 0;
                currentLocation = (Vector2)fireSpriteLocations[currentSprite];
                currentSprite++;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {

            sourceRectangle = new Rectangle((int)currentLocation.X, (int)currentLocation.Y, (int)fireSpriteDimensions.X, (int)fireSpriteDimensions.Y);
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)fireSpriteDimensions.X, (int)fireSpriteDimensions.Y);

            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();

        }

        public Vector2 SpriteDimensions
        {
            get { return fireSpriteDimensions; }
        }

    }
}
