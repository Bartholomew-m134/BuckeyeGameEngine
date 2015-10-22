using Game.Interfaces;
using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities;

namespace Game.Items
{
    public class GreenMushroom : IItem
    {
        private Game1 myGame;
        private ISprite greenMushroomSprite;
        private Vector2 location;
        private ObjectPhysics physics;

        public GreenMushroom(Game1 game)
        {
            myGame = game;
            greenMushroomSprite = ItemsSpriteFactory.CreateGreenMushroomSprite();
            physics = new ObjectPhysics();
        }

        public void Update()
        {
            greenMushroomSprite.Update();
        }

        public void Draw() {
            greenMushroomSprite.Draw(myGame.spriteBatch, location);
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
            get { return greenMushroomSprite; }
            set { greenMushroomSprite = value; }
        }

        public ObjectPhysics Physics
        {
            get { return physics; }
        }
    }
}
