using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class FireRightCrouching : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public FireRightCrouching(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateFireRightCrouchingSprite(game);
        }

        public void left()
        {

        }

        public void right()
        {

        }

        public void up()
        {
            mario.state = new FireRightIdle(mario, game);
        }

        public void down()
        {

        }

        public void land()
        {

        }

        public void jump()
        {

        }

        public void flower()
        {

        }

        public void mushroom()
        {
            mario.state = new NormalRightCrouching(mario, game);
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
