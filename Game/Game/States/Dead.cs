using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States
{
    class Dead : IMarioState
    {
                private Mario mario;

        public Dead(Mario mario)
        {
            this.mario = mario;
        }

    }
}
