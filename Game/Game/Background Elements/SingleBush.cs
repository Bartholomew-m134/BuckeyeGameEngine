using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Background_Elements
{
    class SingleBush:IGameObject
    {

        private Game1 myGame;
        private ISprite singleBushSprite;
        private Vector2 location;
        private bool isVisible;

        public SingleBush(Game1 game)
        {
            myGame = game;
            singleBushSprite = BackgroundElementsSpriteFactory.CreateSingleBushSprite();
            isVisible = true;
        }

        public void Update()
        {
            singleBushSprite.Update();
        }
       
        public void Draw() {
            if (isVisible)
            {
                singleBushSprite.Draw(myGame.spriteBatch, location);
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
            get { return singleBushSprite; }
        }
    }
  }

