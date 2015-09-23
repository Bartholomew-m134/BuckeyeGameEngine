using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class SmallLeftJumping : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public SmallLeftJumping(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateSmallLeftJumpingSprite(game);
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
            mario.state = new SmallLeftIdle(mario, game);
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
            mario.state = new NormalLeftJumping(mario, game);
        }

        public void damage()
        {
            //mario.state = new Dead(mario, game);
        }

        public void die()
        {
            mario.state = new Dead(mario, game);
        }
    }
}
