using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class FireRightJumping : IMarioState
    {

        private MarioInstance mario;

        public FireRightJumping(MarioInstance mario)
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
            mario.state = new FireRightIdle(mario);
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
            mario.state = new SmallRightJumping(mario);
        }

        public void die()
        {
            mario.state = new Dead(mario);
        }

    }
}
