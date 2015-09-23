using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalRightIdle : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public NormalRightIdle(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            SpriteFactories.MarioSpriteFactory.CreateNormalRightIdleSprite(game);
        }

        public void left()
        {
            mario.state = new NormalLeftIdle(mario, game);
        }

        public void right()
        {
            mario.state = new NormalRightRunning(mario, game);
        }

        public void up()
        {

        }

        public void down()
        {
            mario.state = new NormalRightCrouching(mario, game);
        }

        public void land()
        {

        }

        public void jump()
        {
            mario.state = new NormalRightJumping(mario, game);
        }

        public void flower()
        {
            mario.state = new FireRightIdle(mario, game);
        }

        public void mushroom()
        {

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
