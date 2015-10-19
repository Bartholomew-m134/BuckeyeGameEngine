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

        public SingleBush(Game1 game)
        {
            myGame = game;
            singleBushSprite = BackgroundElementsSpriteFactory.CreateSingleBushSprite();
        }

        public void Update()
        {
            singleBushSprite.Update();
        }
       
        public void Draw() {
            
                singleBushSprite.Draw(myGame.spriteBatch, location);
            
        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite GetSetSprite
        {
            get { return singleBushSprite; }
            set { singleBushSprite = value; }
        }
    }
  }

