using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class FireLeftIdle : IMarioState
    {

        private MarioInstance mario;

        public FireLeftIdle(MarioInstance mario)
        {
            this.mario = mario;
        }

        public void left()
        {
            mario.state = new FireLeftRunning(mario);
        }

        public void right()
        {
            mario.state = new FireRightIdle(mario);
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
            mario.state = new SmallLeftIdle(mario);
        }

        public void die()
        {
            mario.state = new Dead(mario);
        }


    }
}
