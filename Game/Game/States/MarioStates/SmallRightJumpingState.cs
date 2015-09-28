using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class SmallRightJumping : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public SmallRightJumping(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightJumpingSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {

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
            mario.state = new SmallRightIdle(mario, game);
        }

        public void Jump()
        {

        }

        public void Flower()
        {
            mario.state = new FireRightJumping(mario, game);
        }

        public void Mushroom()
        {
            mario.state = new NormalRightJumping(mario, game);
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
