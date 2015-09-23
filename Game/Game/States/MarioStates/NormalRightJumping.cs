using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalRightJumping : IMarioState
    {

               private MarioInstance mario;

        public NormalRightJumping(MarioInstance mario)
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
            mario.state = new NormalRightIdle(mario);
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
