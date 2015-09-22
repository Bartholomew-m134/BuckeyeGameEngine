using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States
{
    class SmallLeftJumping : IMarioState
    {

        private Mario mario;

        public SmallLeftJumping(Mario mario)
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
            mario.state = new SmallLeftIdle(mario);
        }

        public void jump()
        {

        }

        public void flower()
        {
            mario.state = new FireLeftJumping(mario);
        }

        public void mushroom()
        {
            mario.state = new NormalLeftJumping(mario);
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
