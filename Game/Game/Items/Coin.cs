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
        private IItemSprite coinSprite;
        private Vector2 location;
        private ObjectPhysics physics;
        private bool isInsideBlock;
        private int riseTimer;

        public Coin(bool isInsideBlock, Game1 game)
        {
            this.isInsideBlock = isInsideBlock;
            myGame = game;
            coinSprite = ItemsSpriteFactory.CreateCoinSprite();
            physics = new ObjectPhysics();
            riseTimer = 100;
        }

        public void Update()
        {
            coinSprite.Update();
        }

        public void Draw(ICamera camera)
        {
            if (!isInsideBlock && riseTimer >0)
            {
                coinSprite.RiseDraw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
                riseTimer--;
            }
            else
            {
                //coinSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
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
            get { return (ISprite)coinSprite; }
            set { coinSprite = (IItemSprite)value; }
        }

        public ObjectPhysics Physics
        {
            get { return physics; }
        }

        public bool IsInsideBlock {
            get { return isInsideBlock; }
            set { isInsideBlock = value; }
        }
    }
}
