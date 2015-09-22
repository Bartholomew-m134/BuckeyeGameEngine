using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States
{
    class NormalRightIdle : IMarioState
    {

               private Mario mario;

        public NormalRIghtIdle(Mario mario)
        {
            this.mario = mario;
        }

        public void left()
        {
            mario.state = new NormalLeftIdle(mario);
        }

        public void right()
        {
            mario.state = new NormalRightRunning(mario);
        }

        public void up()
        {

        }

        public void down()
        {
            mario.state = new NormalRightCrouching(mario);
        }

        public void land()
        {

        }

        public void jump()
        {
            mario.state = new NormalRightJumping(mario);
        }

        public void flower()
        {
            mario.state = new FireRightIdle(mario);
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
