using Game.Interfaces;
using Game.SpriteFactories;
using Game.Utilities;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.FlagPoles
{
    public class TopOfPole : IFlagPole
    {
        private Game1 myGame;
        private ISprite topOfPoleSprite;
        private Vector2 location;
        private bool isActive;
        private bool hasBeenActivatedOnce;

        public TopOfPole(Game1 game)
        {
            myGame = game;
            topOfPoleSprite = TileSpriteFactory.CreateTopOfFlagPoleSprite();
            isActive = false;
            hasBeenActivatedOnce = false;
        }

        public void Update()
        {
            topOfPoleSprite.Update();
        }

        public void Draw(ICamera camera)
        {
            topOfPoleSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }


        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return topOfPoleSprite; }
            set { topOfPoleSprite = value; }
        }

        public ObjectPhysics Physics
        {
            get { return null; }
        }

        public bool IsActive{
            get {return isActive;}
            set {isActive = value;}
        }

        public bool HasBeenActivatedOnce
        {
            get { return hasBeenActivatedOnce; }
            set { hasBeenActivatedOnce = value; }
        }
    }
}
