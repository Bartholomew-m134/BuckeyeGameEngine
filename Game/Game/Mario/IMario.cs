using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Mario
{
    public interface IMario
    {
        void Update();

        void Draw();

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
