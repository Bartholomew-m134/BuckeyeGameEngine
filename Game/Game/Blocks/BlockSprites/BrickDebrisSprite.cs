using Game.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Game.Blocks.BlockSprites
{
    class BrickDebrisSprite : ISprite
    {
        private Texture2D spriteSheet;
        private int width;
        private int height;
        private int sheetXLocation;
        private int sheetYLocation;
        private int timer;
        private Vector2 topLeftDestination;
        private Vector2 topRightDestination;
        private Vector2 bottomLeftDestination;
        private Vector2 bottomRightDestination;
        private int xMovement;
        private int yMovement;
        private int debrisHeightCheck;
        private bool goingUp;

        public BrickDebrisSprite(Texture2D spriteSheet)
        {
            this.spriteSheet = spriteSheet;
            width = 8;
            height = 8;
            sheetXLocation = 304;
            sheetYLocation = 112;
            xMovement = 1;
            yMovement = 3;
            debrisHeightCheck = 0;
            timer = 0;
            goingUp = true;

            topLeftDestination.X = 0;
            topLeftDestination.Y = 0;

            topRightDestination.X = 0;
            topRightDestination.Y = 0;

            bottomLeftDestination.X = 0;
            bottomLeftDestination.Y = 0;

            bottomRightDestination.X = 0;
            bottomRightDestination.Y = 0;

        }

        public void Update()
        {
           if (debrisHeightCheck > 4 && goingUp){
                yMovement = yMovement * -1;
                debrisHeightCheck = 0;
                goingUp = false;
            }
           else
           {
               topLeftDestination.X -= xMovement;
               topLeftDestination.Y -= yMovement * 2;

               topRightDestination.X += xMovement;
               topRightDestination.Y -= yMovement * 2;

               bottomLeftDestination.X += xMovement;
               bottomLeftDestination.Y -= yMovement * 2;

               bottomRightDestination.X -= xMovement;
               bottomRightDestination.Y -= yMovement * 2;
           }
            debrisHeightCheck += 1;
            timer++;
            
        }

        public void Draw(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(sheetXLocation, sheetYLocation, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            if(topLeftDestination.X ==0){
                topLeftDestination.X = destinationRectangle.X;
                topLeftDestination.Y = destinationRectangle.Y;

                topRightDestination.X = destinationRectangle.X + 8;
                topRightDestination.Y = destinationRectangle.Y;

                bottomLeftDestination.X = destinationRectangle.X;
                bottomLeftDestination.Y = destinationRectangle.Y + 8;

                bottomRightDestination.X = destinationRectangle.X + 8;
                bottomRightDestination.Y = destinationRectangle.Y + 8;
             }

            if (timer <100){
                spriteBatch.Begin();
                spriteBatch.Draw(spriteSheet, topLeftDestination, sourceRectangle, Color.White);
                spriteBatch.Draw(spriteSheet, topRightDestination, sourceRectangle, Color.White);
                spriteBatch.Draw(spriteSheet, bottomLeftDestination, sourceRectangle, Color.White);
                spriteBatch.Draw(spriteSheet, bottomRightDestination, sourceRectangle, Color.White);
                spriteBatch.End();
            }
            
        }

        public Vector2 SpriteDimensions
        {
            get { return new Vector2(width, height); }
        }

    }
}
