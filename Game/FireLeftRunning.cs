using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States
{
    class FireLeftRunning : IMarioState
    {

               private Mario mario;

        public FireLeftRunning(Mario mario)
        {
            this.mario = mario;
        }

        public void left()
        {

        }

        public void right()
        {
            mario.state = new FireLeftIdle(mario);
        }

        public void up()
        {

        }

        public void down()
        {
            mario.state = new FireLeftCrouching(mario);
        }

        public void land()
        {

        }

        public void jump()
        {
            mario.state = new FireLeftJumping(mario);
        }

        public void flower()
        {

        }

        public void mushroom()
        {

        }

        public void damage()
        {
            mario.state = new SmallLeftRunning(mario);
        }

        public void die()
        {
            mario.state = new Dead(mario);
        }

    }
}
