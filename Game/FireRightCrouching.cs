using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States
{
    class FireRightCrouching : IMarioState
    {

               private Mario mario;

        public FireRightCrouching(Mario mario)
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
            mario.state = new FireRightIdle(mario);
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

        }

        public void mushroom()
        {

        }

        public void damage()
        {
            mario.state = new SmallRightIdle(mario);
        }

        public void die()
        {
            mario.state = new Dead(mario);
        }

    }
}
