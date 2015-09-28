using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class SmallRightRunning : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public SmallRightRunning(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightRunningSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void left()
        {
            mario.state = new SmallRightIdle(mario, game);
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

        }

        public void jump()
        {
            mario.state = new SmallRightJumping(mario, game);
        }

        public void flower()
        {
            mario.state = new FireRightRunning(mario, game);
        }

        public void mushroom()
        {
            mario.state = new NormalRightRunning(mario, game);
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
