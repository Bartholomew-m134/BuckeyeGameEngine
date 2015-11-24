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
    class InvisibleFlagPoleBarrier : IFlagPole
    {
        public bool isActive;
        private Game1 myGame;
        private ISprite invisibleFlagPoleSprite;
        private Vector2 location;
        public bool hasBeenActivatedOnce;

        public InvisibleFlagPoleBarrier(Game1 game)
        {
            hasBeenActivatedOnce = false;
            myGame = game;
            invisibleFlagPoleSprite = TileSpriteFactory.CreateInvisibleFlagPoleSprite();
            isActive = false;
        }

        public void Update()
        {
            invisibleFlagPoleSprite.Update();
        }

        public void Draw(ICamera camera)
        {
            invisibleFlagPoleSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }


        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return invisibleFlagPoleSprite; }
            set { invisibleFlagPoleSprite = value; }
        }

        public IPhysics Physics
        {
            get { return null; }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
        public bool HasBeenActivatedOnce
        {
            get { return hasBeenActivatedOnce; }
            set { hasBeenActivatedOnce = value; }
        }
    }
}
