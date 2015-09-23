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
        private Game1 game;

        public NormalLeftIdle(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            SpriteFactories.MarioSpriteFactory.CreateNormalLeftIdleSprite(game);
        }

        public void left()
        {
            mario.state = new NormalLeftRunning(mario, game);
        }

        public void right()
        {
            mario.state = new NormalRightIdle(mario, game);
        }

        public void up()
        {

        }

        public void down()
        {
            mario.state = new NormalLeftCrouching(mario, game);
        }

        public void land()
        {

        }

        public void jump()
        {
            mario.state = new NormalLeftJumping(mario, game);
        }

        public void flower()
        {
            mario.state = new FireLeftIdle(mario, game);

        }

        public void mushroom()
        {

        }

        public void damage()
        {
            mario.state = new SmallLeftIdle(mario, game);
        }

        public void die()
        {
            mario.state = new Dead(mario, game);
        }

    }
}
