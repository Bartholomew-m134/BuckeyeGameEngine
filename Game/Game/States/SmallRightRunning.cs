using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States
{
    class SmallRightRunning : IMarioState
    {

        private Mario mario;

        public SmallRightRunning(Mario mario)
        {
            this.mario = mario;
        }

        public void left()
        {
            mario.state = new SmallRightIdle(mario);
        }

        public void right()
        {

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
            mario.state = new SmallRightJumping(mario);
        }

        public void flower()
        {
            mario.state = new FireRightRunning(mario);
        }

        public void mushroom()
        {
            mario.state = new NormalRightRunning(mario);
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
