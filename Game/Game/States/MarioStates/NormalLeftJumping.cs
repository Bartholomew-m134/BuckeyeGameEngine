﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalLeftJumping : IMarioState
    {

        private MarioInstance mario;

        public NormalLeftJumping(MarioInstance mario)
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
            mario.state = new NormalLeftIdle(mario);
        }

        public void jump()
        {

        }

        public void flower()
        {
            mario.state = new FireLeftJumping(mario);
        }

        public void mushroom()
        {

        }

        public void damage()
        {
            mario.state = new SmallLeftJumping(mario);
        }

        public void die()
        {
            mario.state = new Dead(mario);
        }

    }
}