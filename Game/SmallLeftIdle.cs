using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States
{
    class SmallLeftIdle : IMarioState
    {

               private Mario mario;

        public SmallLeftIdle(Mario mario)
        {
            this.mario = mario;
        }

        public void left()
        {
            mario.state = new SmallLeftRunning(mario);
        }

        public void right()
        {
            mario.state = new SmallRightIdle(mario);
        }

        public void up()
        {

        }

        public void down()
        {

        }

        public void land()
        {

        }

        public void jump()
        {
            mario.state = new SmallLeftJumping(mario);
        }

        public void flower()
        {
            mario.state = new FireLeftIdle(mario);
        }

        public void mushroom()
        {
            mario.state = new NormalLeftIdle(mario);
        }

        public void damage()
        {
            mario.state = new Dead(mario);
        }

        public void die()
        {
            mario.state = new Dead(mario);
        }

    }
}
