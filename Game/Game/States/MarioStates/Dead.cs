using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.States.MarioStates
{
    class Dead : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;
        private Texture2D texture;

        public Dead(MarioInstance mario)
        {
            this.mario = mario;
            mario.sprite = new Game.Mario.MarioSprites.DeadSprite(texture, game);

        }
    
    }
}
