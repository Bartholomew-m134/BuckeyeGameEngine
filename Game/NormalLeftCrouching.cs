using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States
{
    class NormalLeftCrouching : IMarioState
    {

               private Mario mario;

        public NormalLeftCrouching(Mario mario)
        {
            this.mario = mario;
        }

        public void left()
        {
 
        }

        public void right()
        {

        }

        public void up()
        {
            mario.state = new NormalLeftIdle(mario);
        }

        public void down()
        {

        }

        public void land()
        {

        }

        public void jump()
        {

        }

        public void flower()
        {
            mario.state = new FireLeftCrouching(mario);
        }

        public void mushroom()
        {

        }

        public void damage()
        {
            mario.state = new SmallLeftIdle(mario);
        }

        public void die()
        {
            mario.state = new Dead(mario);
        }

    }
}
