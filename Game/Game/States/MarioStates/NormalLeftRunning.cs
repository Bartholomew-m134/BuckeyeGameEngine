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
        private Game1 game;

        public NormalLeftRunning(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            SpriteFactories.MarioSpriteFactory.CreateNormalLeftRunningSprite(game);
        }

        public void left()
        {

        }

        public void right()
        {
            mario.state = new NormalLeftIdle(mario, game);
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
            mario.state = new FireRightRunning(mario, game);
        }

        public void mushroom()
        {

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
