using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States
{
    class SmallRightJumping : IMarioState
    {

        private Mario mario;

        public SmallRightJumping(Mario mario)
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

        }

        public void down()
        {

        }

        public void land()
        {
            mario.state = new SmallRightIdle(mario);
        }

        public void jump()
        {

        }

        public void flower()
        {
            mario.state = new FireRightJumping(mario);
        }

        public void mushroom()
        {
            mario.state = new NormalRightJumping(mario);
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
