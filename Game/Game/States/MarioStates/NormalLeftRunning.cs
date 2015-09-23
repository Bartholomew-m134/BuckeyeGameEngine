using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalLeftRunning : IMarioState
    {

        private MarioInstance mario;

        public NormalLeftRunning(MarioInstance mario)
        {
            this.mario = mario;
        }

        public void left()
        {

        }

        public void right()
        {
            mario.state = new NormalLeftIdle(mario);
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
            mario.state = new FireRightRunning(mario);
        }

        public void mushroom()
        {

        }

        public void damage()
        {
            mario.state = new SmallLeftRunning(mario);
        }

        public void die()
        {
            mario.state = new Dead(mario);
        }

    }
}
