﻿using Game.Interfaces;
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
        private bool isInsideBlock;


        public Star(bool isInsideBlock, Game1 game)
        {
            this.isInsideBlock = isInsideBlock;
            myGame = game;
            starSprite = ItemsSpriteFactory.CreateStarSprite();
            physics = new ObjectPhysics();
            physics.Acceleration = Vector2.Zero;
        }

        public void Update()
        {
            starSprite.Update();
            location = physics.Update(location);
        }

        public void Draw(ICamera camera)
        {
            if (!isInsideBlock)
                starSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public void Disappear() {
            ScoreManager.location = location;
            location.Y += 2000;
            ScoreManager.IncreaseScore(1000);
        }

        public void Release()
        {
            if (isInsideBlock)
            {
                isInsideBlock = false;
                physics.ResetPhysics();
                physics.Velocity = new Vector2(0, -1);
            }
        }

        public void ReverseDirection()
        {
            physics.Velocity *= new Vector2(-1, 1);
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
        public bool IsInsideBlock
        {
            get { return isInsideBlock; }
            set { isInsideBlock = value; }
        }
    }
}
