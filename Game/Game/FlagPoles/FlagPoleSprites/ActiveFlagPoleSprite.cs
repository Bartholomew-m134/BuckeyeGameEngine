using Game.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.FlagPoles.FlagPoleSprites
{
    class ActiveFlagPoleSprite : ISprite
    {
        private Texture2D Texture { get; set; }
        private int width;
        private int height;

        private Vector2 firstFlagFrame;
        private Vector2 secondFlagFrame;
        private Vector2 thirdFlagFrame;
        private Vector2 fourthFlagFrame;
        private Vector2 fifthFlagFrame;

        private int currentSourceFrame;
        private Vector2 currentSourceCoordinates;
        private ArrayList flagPoleSources;
        public ActiveFlagPoleSprite(Texture2D texture)
        {
            Texture = texture;
            flagPoleSources = new ArrayList();
            currentSourceCoordinates.X = 0;
            currentSourceCoordinates.Y = 0;
            currentSourceFrame = 0;

            firstFlagFrame.X = 248;
            firstFlagFrame.Y = 586;

            secondFlagFrame.X = 215;
            secondFlagFrame.Y = 586;

            thirdFlagFrame.X = 181;
            thirdFlagFrame.Y = 586;

            fourthFlagFrame.X = 148;
            fourthFlagFrame.Y = 586;

            fifthFlagFrame.X = 115;
            fifthFlagFrame.Y = 586;

            width = 25;
            height = 176;

            flagPoleSources.Add(firstFlagFrame);
            flagPoleSources.Add(secondFlagFrame);
            flagPoleSources.Add(thirdFlagFrame);
            flagPoleSources.Add(fourthFlagFrame);
            flagPoleSources.Add(fifthFlagFrame);
        }

        public void Update()
        {
            
                if (currentSourceFrame < 5)
                {
                    currentSourceCoordinates = (Vector2)flagPoleSources[currentSourceFrame];
                    currentSourceFrame++;
                }
                

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {



            Rectangle sourceRectangle = new Rectangle((int)currentSourceCoordinates.X, (int)currentSourceCoordinates.Y, width, height);
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
