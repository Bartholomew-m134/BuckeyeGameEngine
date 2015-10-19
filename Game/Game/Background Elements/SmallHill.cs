using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Background_Elements
{
    class SmallHill:IGameObject
    {
        private Game1 myGame;
        private ISprite smallHillSprite;
        private Vector2 location;


        public SmallHill(Game1 game)
        {
            myGame = game;
            smallHillSprite = BackgroundElementsSpriteFactory.CreateSmallHillSprite();

        }

        public void Update()
        {
            smallHillSprite.Update();
        }
       
        public void Draw() {
          
                smallHillSprite.Draw(myGame.spriteBatch, location);
            
        }


        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite GetSetSprite
        {
            get { return smallHillSprite; }
            set { smallHillSprite = value; }
        }
    }
 }

