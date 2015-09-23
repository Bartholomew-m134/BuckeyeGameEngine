using System;
using System.Collections.Generic;
using System.Linq;
using Game.Mario;
using System.Text;

namespace Game.States
{
    class FireRightRunning : IMarioState
    {

        private MarioInstance mario;

        public FireRightRunning(MarioInstance mario)
        {
            this.mario = mario;
        }

        public void left()
        {
            mario.state = new FireRightIdle(mario);
        }

        public void right()
        {

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
            mario.state = new SmallRightRunning(mario);
        }

        public void die()
        {
            mario.state = new Dead(mario);
        }

    }
}
