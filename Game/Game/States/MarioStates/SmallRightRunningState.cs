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

        public void Left()
        {
            mario.state = new SmallRightIdle(mario, game);
        }

        public void Right()
        {

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
            mario.state = new FireRightRunning(mario, game);
        }

        public void Mushroom()
        {
            mario.state = new NormalRightRunning(mario, game);
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
