using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States
{
    public interface IMarioState
    {
         void Update();

         void left();


         void right();


         void up();


         void down();


         void land();


         void jump();


         void flower();


         void mushroom();


         void damage();


         void die();


    }
}
