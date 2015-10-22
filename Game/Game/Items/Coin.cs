using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.SpriteFactories;
using Game.Interfaces;
using Game.Utilities;

namespace Game.Items
{
    public class Coin : IItem
    {
        private Game1 myGame;
        private ISprite coinSprite;
        private Vector2 location;
        private ObjectPhysics physics;

        public Coin(Game1 game)
        {
            myGame = game;
            coinSprite = ItemsSpriteFactory.CreateCoinSprite();
            physics = new ObjectPhysics();
        }

        public void Update()
        {
            coinSprite.Update();
        }
       
        public void Draw() {
            coinSprite.Draw(myGame.spriteBatch, location);
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
            get { return coinSprite; }
            set { coinSprite = value; }
        }

        public ObjectPhysics Physics
        {
            get { return physics; }
        }
    }
}
