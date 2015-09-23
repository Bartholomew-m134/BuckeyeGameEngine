using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalLeftIdle : IMarioState
    {

        private MarioInstance mario;

        public NormalLeftIdle(MarioInstance mario)
        {
            this.mario = mario;
        }

        public void left()
        {
            mario.state = new NormalLeftRunning(mario);
        }

        public void right()
        {
            mario.state = new NormalRightIdle(mario);
        }

        public void up()
        {

        }

        public void down()
        {
            mario.state = new NormalLeftCrouching(mario);
        }

        public void land()
        {

        }

        public void jump()
        {
            mario.state = new NormalLeftJumping(mario);
        }

        public void flower()
        {
            mario.state = new FireLeftIdle(mario);

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
