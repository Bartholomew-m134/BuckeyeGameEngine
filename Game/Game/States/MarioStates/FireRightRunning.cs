using System;
using System.Collections.Generic;
using System.Linq;
using Game.Mario;
using System.Text;

namespace Game.States
{
    class FireRightRunning : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public FireRightRunning(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateFireRightRunningSprite(game);
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void left()
        {
            mario.state = new FireRightIdle(mario, game);
        }

        public void right()
        {

        }

        public void up()
        {

        }

        public void down()
        {
            mario.state = new FireRightCrouching(mario, game);
        }

        public void land()
        {

        }

        public void jump()
        {
            mario.state = new FireRightJumping(mario, game);
        }

        public void flower()
        {

        }

        public void mushroom()
        {
            mario.state = new NormalRightRunning(mario, game);
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
