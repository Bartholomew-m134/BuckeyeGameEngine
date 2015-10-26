using Game.Interfaces;
using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities;

namespace Game.FlagPoles
{
    class FlagPole : IFlagPole
    {
        public bool isActive;
        private bool hasBeenActivatedOnce;
        private Game1 myGame;
        private ISprite flagPoleSprite;
        private Vector2 location;

        public FlagPole(Game1 game)
        {
            myGame = game;
            flagPoleSprite = TileSpriteFactory.CreateInactiveFlagPoleSprite();
            isActive = false;
            hasBeenActivatedOnce = false;
        }

        public void Update()
        {
            if(this.isActive && !hasBeenActivatedOnce){
                flagPoleSprite = TileSpriteFactory.CreateActiveFlagPoleSprite();
                hasBeenActivatedOnce = true;
            }
            flagPoleSprite.Update();
        }

        public void Draw(ICamera camera)
        {
            flagPoleSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }


        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return flagPoleSprite; }
            set { flagPoleSprite = value; }
        }

        public ObjectPhysics Physics
        {
            get { return null; }
        }

        public bool IsActive{
            get {return isActive;}
            set {isActive = value;}
        }
    }
}