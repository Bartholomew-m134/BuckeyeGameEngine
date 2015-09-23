using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class SmallLeftIdle : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public SmallLeftIdle(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            SpriteFactories.MarioSpriteFactory.CreateSmallLeftIdleSprite(game);
        }

        public void left()
        {
            mario.state = new SmallLeftRunning(mario, game);
        }

        public void right()
        {
            mario.state = new SmallRightIdle(mario, game);
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
            mario.state = new SmallLeftJumping(mario, game);
        }

        public void flower()
        {
            mario.state = new FireLeftIdle(mario, game);
        }

        public void mushroom()
        {
            mario.state = new NormalLeftIdle(mario, game);
        }

        public void damage()
        {
            mario.state = new Dead(mario, game);
        }

        public void die()
        {
            mario.state = new Dead(mario, game);
        }

    }
}
