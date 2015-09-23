using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;


namespace Game.States
{
    class Dead : IMarioState
    {

        private MarioInstance mario;
        Game1 game;

        public Dead(MarioInstance mario)
        {
            this.mario = mario;
            SpriteFactories.MarioSpriteFactory.CreateDeadSprite(game);
        }



    }
}
