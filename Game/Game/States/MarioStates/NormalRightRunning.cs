using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalRightRunning : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public NormalRightRunning(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightRunningSprite(game);
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void left()
        {
            mario.state = new NormalRightIdle(mario, game);
        }

        public void right()
        {

        }

        public void up()
        {

        }

        public void down()
        {
            mario.state = new NormalRightCrouching(mario, game);
        }

        public void land()
        {

        }

        public void jump()
        {
            mario.state = new NormalRightJumping(mario, game);
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
            mario.state = new SmallRightRunning(mario, game);
        }

        public void die()
        {
            mario.state = new Dead(mario, game);
        }

    }
}
