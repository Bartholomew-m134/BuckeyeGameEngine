using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class SmallRightJumping : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public SmallRightJumping(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightJumpingSprite();
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
            mario.state = new SmallRightIdle(mario, game);
        }

        public void jump()
        {

        }

        public void flower()
        {
            mario.state = new FireRightJumping(mario, game);
        }

        public void mushroom()
        {
            mario.state = new NormalRightJumping(mario, game);
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
