﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Mario.MarioSprites
{
    public class DeadSprite : ISprite
    {
        private Texture2D Texture { get; set; }


        public DeadSprite(Texture2D texture, Game1 game) {
            Texture = texture;  
        }
        void Update()
        {
            
        }

        void Draw()
        {
            
        }
    }
}
