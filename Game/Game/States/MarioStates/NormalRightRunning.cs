using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalRightRunning : IMarioState
    {

        private MarioInstance mario;

        public NormalRightRunning(MarioInstance mario)
        {
            this.mario = mario;
        }

        public void left()
        {
            mario.state = new NormalRightIdle(mario);
        }

        public void right()
        {

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
            mario.state = new FireRightRunning(mario);
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
