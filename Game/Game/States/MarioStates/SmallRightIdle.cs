using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class SmallRightIdle : IMarioState
    {

        private MarioInstance mario;

        public SmallRightIdle(MarioInstance mario)
        {
            this.mario = mario;
        }

        public void left()
        {
            mario.state = new SmallLeftIdle(mario);
        }

        public void right()
        {
            mario.state = new SmallRightRunning(mario);
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
            mario.state = new FireRightIdle(mario);
        }

        public void mushroom()
        {
            mario.state = new NormalRightIdle(mario);
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
