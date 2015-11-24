using Game.Interfaces;
using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities;
using Game.Utilities.Constants;

namespace Game.Items
{
    public class RedMushroom : IItem
    {
        private Game1 myGame;
        private ISprite redMushroomSprite;
        private Vector2 location;
        private IPhysics physics;
        private bool isInsideBlock;


        public RedMushroom(bool isInsideBlock, Game1 game)
        {
            this.isInsideBlock = isInsideBlock;
            myGame = game;
            redMushroomSprite = ItemsSpriteFactory.CreateRedMushroomSprite();
            physics = new MarioGamePhysics();
            physics.Acceleration = Vector2.Zero;
           
        }

        public void Update()
        {
            redMushroomSprite.Update();
            location = physics.Update(location);
        }

        public void Draw(ICamera camera)
        {
            if(!isInsideBlock)
                redMushroomSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public void Disappear() {
            location.Y += ItemConstants.RELEASEITEM;
        }

        public void Release()
        {
            if (isInsideBlock)
            {
                isInsideBlock = false;
                
                physics.ResetPhysics();
                physics.Acceleration = Vector2.Zero;
                physics.Velocity = new Vector2(ItemConstants.RELEASEXVELOCITY, ItemConstants.RELEASEYVELOCITY);
            }
        }

        public void ReverseDirection()
        {
            physics.Velocity *= new Vector2(ItemConstants.REVERSEXVELOCITY, ItemConstants.REVERSEYVELOCITY);
        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return redMushroomSprite; }
            set { redMushroomSprite = value; }
        }

        public IPhysics Physics
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
