using Game.Interfaces;
using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Items
{
    public class Flower : IItem
    {
        private Game1 myGame;
        private ISprite flowerSprite;
        private Vector2 location;

        public Flower(Game1 game)
        {
            myGame = game;
            flowerSprite = ItemsSpriteFactory.CreateFlowerSprite();
        }

        public void Update()
        {
            flowerSprite.Update();
        }

        public void Draw(ICamera camera)
        {
            flowerSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public void Disappear() {
            location.Y -= 2000;
        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite GetSetSprite
        {
            get { return flowerSprite; }
            set { flowerSprite = value; }
        }

    }

}
