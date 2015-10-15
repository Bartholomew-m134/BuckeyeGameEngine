using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Items
{
    public class Star : IItem
    {
        private Game1 myGame;
        private ISprite starSprite;
        private Vector2 location;

        public Star(Game1 game)
        {
            myGame = game;
            starSprite = ItemsSpriteFactory.CreateStarSprite();
        }

        public void Update()
        {
            starSprite.Update();
        }

        public void Draw() {
            starSprite.Draw(myGame.spriteBatch, location);
        }
        public void Disappear() {
            WorldManager.FreeObject(this);
        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite GetSetSprite
        {
            get { return starSprite; }
            set { starSprite = value; }
        }

    }
}
