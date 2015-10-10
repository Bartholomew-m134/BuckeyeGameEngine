using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Background_Elements
{
    class BigHill:IGameObject
    {

        private Game1 myGame;
        private ISprite bigHillSprite;
        private Vector2 location;
        private bool isVisible;

        public BigHill(Game1 game)
        {
            myGame = game;
            bigHillSprite = BackgroundElementsSpriteFactory.CreateBigHillSprite();
            isVisible = true;
        }

        public void Update()
        {
            bigHillSprite.Update();
        }
       
        public void Draw() {
            if (isVisible)
            {
                bigHillSprite.Draw(myGame.spriteBatch, location);
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
            get { return bigHillSprite; }
            set { bigHillSprite = value; }
        }
    }
}
