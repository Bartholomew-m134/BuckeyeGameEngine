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
        private bool isInsideBlock;
        private bool isReleased;

        public Coin(bool isInsideBlock, Game1 game)
        {
            this.isInsideBlock = isInsideBlock;
            isReleased = false;
            myGame = game;
            coinSprite = ItemsSpriteFactory.CreateCoinSprite();
            physics = new ObjectPhysics();
            physics.Acceleration = Vector2.Zero;
        }

        public void Update()
        {
            coinSprite.Update();
            location = physics.Update(location);
        }

        public void Draw(ICamera camera)
        {
            if (!isInsideBlock || (isReleased && physics.Velocity.Y <= 0))
            {
                coinSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
            }
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
            get { return coinSprite; }
            set { coinSprite = value; }
        }

        public ObjectPhysics Physics
        {
            get { return physics; }
        }

        public bool IsInsideBlock {
            get { return isInsideBlock; }
            set { isInsideBlock = value; }
        }

        public void Release()
        {
            if (isInsideBlock && !isReleased)
            {
                isReleased = true;
                physics.ResetPhysics();
                physics.Velocity = new Vector2(0, -7);
            }
        }
    }
}
