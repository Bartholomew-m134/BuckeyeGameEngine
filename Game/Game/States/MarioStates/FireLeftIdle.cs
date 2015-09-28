using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class FireLeftIdle : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public FireLeftIdle(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateFireLeftIdleSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void left()
        {
            mario.state = new FireLeftRunning(mario, game);
        }

        public void right()
        {
            mario.state = new FireRightIdle(mario, game);
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
            mario.state = new NormalLeftIdle(mario, game);
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
