using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalRightCrouching : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public NormalRightCrouching(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightCrouchingSprite();
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
            mario.state = new NormalRightIdle(mario, game);
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
            mario.state = new FireRightCrouching(mario, game);
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
