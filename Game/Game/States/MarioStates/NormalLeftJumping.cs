using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalLeftJumping : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public NormalLeftJumping(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            SpriteFactories.MarioSpriteFactory.CreateNormalLeftJumpingSprite(game);
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
            mario.state = new NormalLeftIdle(mario, game);
        }

        public void jump()
        {

        }

        public void flower()
        {
            mario.state = new FireLeftJumping(mario, game);
        }

        public void mushroom()
        {

        }

        public void damage()
        {
            mario.state = new SmallLeftJumping(mario, game);
        }

        public void die()
        {
            mario.state = new Dead(mario, game);
        }

    }
}
