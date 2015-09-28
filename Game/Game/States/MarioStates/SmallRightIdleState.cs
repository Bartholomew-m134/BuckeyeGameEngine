using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class SmallRightIdle : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public SmallRightIdle(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightIdleSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {
            mario.state = new SmallLeftIdle(mario, game);
        }

        public void Right()
        {
            mario.state = new SmallRightRunning(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {

        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.state = new SmallRightJumping(mario, game);
        }

        public void Flower()
        {
            mario.state = new FireRightIdle(mario, game);
        }

        public void Mushroom()
        {
            mario.state = new NormalRightIdle(mario, game);
        }

        public void Damage()
        {
            //mario.state = new Dead(mario, game);
        }

        public void Die()
        {
            mario.state = new Dead(mario, game);
        }
    }
}
