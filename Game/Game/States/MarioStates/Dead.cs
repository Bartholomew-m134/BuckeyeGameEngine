using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class Dead : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;
        private Texture2D spriteSheet;

        public Dead(MarioInstance mario)
        {
            this.mario = mario;
            mario.sprite = new Mario.MarioSprites.DeadSprite(spriteSheet, game);
        }



    }
}
