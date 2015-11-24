using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.SpriteFactories;
using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;

namespace Game.Items
{
    public class Coin : IItem
    {
        private Game1 myGame;
        private ISprite coinSprite;
        private Vector2 location;
        private IPhysics physics;
        private bool isInsideBlock;
        private bool isReleased;

        public Coin(bool isInsideBlock, Game1 game)
        {
            this.isInsideBlock = isInsideBlock;
            isReleased = false;
            myGame = game;
            coinSprite = ItemsSpriteFactory.CreateCoinSprite();
            physics = new MarioGamePhysics();
            physics.Acceleration = Vector2.Zero;
        }

        public void Update()
        {
            coinSprite.Update();
            location = physics.Update(location);
        }

        public void Draw(ICamera camera)
        {
            if (!isInsideBlock || (isReleased && physics.Velocity.Y < ItemConstants.COINYVELOCITYCAP))
                coinSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public void Disappear() {
            location.Y += ItemConstants.RELEASEITEM;
        }

        public void Release()
        {
            if (isInsideBlock && !isReleased)
            {
                isReleased = true;
                physics.ResetPhysics();
                physics.Velocity = new Vector2(0, ItemConstants.COINRELEASEYVELOCITY);
            }
        }

        public void ReverseDirection()
        {
            
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

        public IPhysics Physics
        {
            get { return physics; }
        }

        public bool IsInsideBlock {
            get { return isInsideBlock; }
            set { isInsideBlock = value; }
        }
    }
}
