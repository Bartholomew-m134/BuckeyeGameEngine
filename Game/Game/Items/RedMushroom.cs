﻿using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Items
{
    public class RedMushroom : IItem
    {
        private Game1 myGame;
        private ISprite redMushroomSprite;
        private Vector2 location;
        private bool isVisible;
        public RedMushroom(Game1 game)
        {
            myGame = game;
            redMushroomSprite = ItemsSpriteFactory.CreateRedMushroomSprite();
            location = new Vector2(330, 80);
            isVisible = true;
        }

        public void Update()
        {
            redMushroomSprite.Update();
        }

        public void Draw() {
            if (isVisible)
            {
                redMushroomSprite.Draw(myGame.spriteBatch, location);
            }
        }

        public void Disappear() {
            isVisible = false;
        }
    }
}
