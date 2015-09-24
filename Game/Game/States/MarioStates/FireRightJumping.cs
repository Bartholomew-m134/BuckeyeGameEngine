using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class FireRightJumping : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public FireRightJumping(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateFireRightJumpingSprite(game);
        }
        public void Update()
        {
            mario.sprite.Update();
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
            mario.state = new FireRightIdle(mario, game);
        }

        public void jump()
        {

        }

        public void flower()
        {

        }

        public void mushroom()
        {
            mario.state = new NormalRightJumping(mario, game);
        }

        public void damage()
        {
            mario.state = new SmallRightJumping(mario, game);
        }

        public void die()
        {
            mario.state = new Dead(mario, game);
        }

    }
}
