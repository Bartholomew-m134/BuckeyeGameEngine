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
    public class Star : IItem
    {
        private Game1 myGame;
        private ISprite starSprite;
        private Vector2 location;
        private ObjectPhysics physics;

        public Star(Game1 game)
        {
            myGame = game;
            starSprite = ItemsSpriteFactory.CreateStarSprite();
            physics = new ObjectPhysics();
        }

        public void Update()
        {
            starSprite.Update();
        }

        public void Draw(ICamera camera)
        {
            starSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public void Disappear() {
            location.Y -= 2000;
        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return starSprite; }
            set { starSprite = value; }
        }

        public ObjectPhysics Physics
        {
            get { return physics; }
        }

    }
}
