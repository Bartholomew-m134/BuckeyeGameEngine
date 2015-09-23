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

        public Dead(MarioInstance mario)
        {
            this.mario = mario;
        }

    }
}
