using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States
{
    interface IMarioState
    {
        public void Update();

        public void left();


        public void right();


        public void up();


        public void down();


        public void land();


        public void jump();


        public void flower();


        public void mushroom();


        public void damage();


        public void die();


    }
}
