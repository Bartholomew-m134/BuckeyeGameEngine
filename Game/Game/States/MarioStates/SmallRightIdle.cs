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
        private Game1 game;

        public SmallRightIdle(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            SpriteFactories.MarioSpriteFactory.CreateSmallRightIdleSprite(game);
        }

        public void left()
        {
            mario.state = new SmallLeftIdle(mario, game);
        }

        public void right()
        {
            mario.state = new SmallRightRunning(mario, game);
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
            mario.state = new SmallRightJumping(mario, game);
        }

        public void flower()
        {
            mario.state = new FireRightIdle(mario, game);
        }

        public void mushroom()
        {
            mario.state = new NormalRightIdle(mario, game);
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
