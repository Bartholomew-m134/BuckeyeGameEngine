using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class SmallLeftRunning : IMarioState
    {

        private MarioInstance mario;

        public SmallLeftRunning(MarioInstance mario)
        {
            this.mario = mario;
        }

        public void left()
        {

        }

        public void right()
        {
            mario.state = new SmallLeftIdle(mario);
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
            mario.state = new SmallLeftJumping(mario);
        }

        public void flower()
        {
            mario.state = new FireLeftRunning(mario);
        }

        public void mushroom()
        {
            mario.state = new NormalLeftRunning(mario);
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
