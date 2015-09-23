using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class FireRightIdle : IMarioState
    {

        private MarioInstance mario;

        public FireRightIdle(MarioInstance mario)
        {
            this.mario = mario;
        }

        public void left()
        {
            mario.state = new FireLeftIdle(mario);
        }

        public void right()
        {
            mario.state = new FireRightRunning(mario);
        }

        public void up()
        {

        }

        public void down()
        {
            mario.state = new FireRightCrouching(mario);
        }

        public void land()
        {

        }

        public void jump()
        {
            mario.state = new FireRightJumping(mario);
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
