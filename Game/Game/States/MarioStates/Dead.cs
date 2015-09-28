using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;


namespace Game.States
{
    class Dead : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public Dead(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateDeadSprite();
        }

        public void Update() {
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

        }

        public void jump()
        {

        }

        public void flower()
        {
            mario.state = new FireRightIdle(mario, game);
        }

        public void mushroom()
        {
            mario.state = new NormalRightIdle(mario, game);
        }

        public void damage()
        {
            mario.state = new SmallRightIdle(mario, game);
        }

        public void die()
        {
            
        }

    }
}
