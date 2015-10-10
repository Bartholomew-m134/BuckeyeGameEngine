using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Items
{
    public class GreenMushroom : IItem
    {
        private Game1 myGame;
        private ISprite greenMushroomSprite;
        private Vector2 location;
        private bool isVisible;
        public GreenMushroom(Game1 game)
        {
            myGame = game;
            greenMushroomSprite = ItemsSpriteFactory.CreateGreenMushroomSprite();
            isVisible = true;
        }

        public void Update()
        {
            greenMushroomSprite.Update();
        }

        public void Draw() {
            if (isVisible)
            {
                greenMushroomSprite.Draw(myGame.spriteBatch, location);
            }
        }

        public void Disappear() {
            isVisible = false;
            location.Y -= 1000;
        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite GetSprite
        {
            get { return greenMushroomSprite; }
            set { greenMushroomSprite = value; }
        }
    }
}
