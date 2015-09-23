using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class FireRightIdle : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public FireRightIdle(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            SpriteFactories.MarioSpriteFactory.CreateFireRightIdleSprite(game);
        }

        public void left()
        {
            mario.state = new FireLeftIdle(mario, game);
        }

        public void right()
        {
            mario.state = new FireRightRunning(mario, game);
        }

        public void up()
        {

        }

        public void down()
        {
            mario.state = new FireRightCrouching(mario, game);
        }

        public void land()
        {

        }

        public void jump()
        {
            mario.state = new FireRightJumping(mario, game);
        }

        public void flower()
        {

        }

        public void mushroom()
        {
            mario.state = new NormalRightIdle(mario, game);
        }

        public void damage()
        {
            mario.state = new SmallRightIdle(mario, game);
        }

        public void die()
        {
            mario.state = new Dead(mario, game);
        }

    }
}
