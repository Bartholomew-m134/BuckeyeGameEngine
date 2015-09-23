using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class FireLeftRunning : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public FireLeftRunning(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            SpriteFactories.MarioSpriteFactory.CreateFireLeftRunningSprite(game);
        }

        public void left()
        {

        }

        public void right()
        {
            mario.state = new FireLeftIdle(mario, game);
        }

        public void up()
        {

        }

        public void down()
        {
            mario.state = new FireLeftCrouching(mario, game);
        }

        public void land()
        {

        }

        public void jump()
        {
            mario.state = new FireLeftJumping(mario, game);
        }

        public void flower()
        {

        }

        public void mushroom()
        {
            mario.state = new NormalLeftRunning(mario, game);
        }

        public void damage()
        {
            mario.state = new SmallLeftRunning(mario, game);
        }

        public void die()
        {
            mario.state = new Dead(mario, game);
        }

    }
}
