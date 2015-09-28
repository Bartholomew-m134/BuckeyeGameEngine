using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalRightJumping : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public NormalRightJumping(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightJumpingSprite();
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
            mario.state = new NormalRightIdle(mario, game);
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
