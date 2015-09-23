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
        private Game1 game;

        public SmallLeftRunning(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            SpriteFactories.MarioSpriteFactory.CreateSmallLeftRunningSprite(game);
        }

        public void left()
        {

        }

        public void right()
        {
            mario.state = new SmallLeftIdle(mario, game);
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
            mario.state = new FireLeftRunning(mario, game);
        }

        public void mushroom()
        {
            mario.state = new NormalLeftRunning(mario, game);
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
