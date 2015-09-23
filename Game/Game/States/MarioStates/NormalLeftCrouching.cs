using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalLeftCrouching : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public NormalLeftCrouching(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftCrouchingSprite(game);
        }

        public void left()
        {
 
        }

        public void right()
        {

        }

        public void up()
        {
            mario.state = new NormalLeftIdle(mario, game);
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
            mario.state = new FireLeftCrouching(mario, game);
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
