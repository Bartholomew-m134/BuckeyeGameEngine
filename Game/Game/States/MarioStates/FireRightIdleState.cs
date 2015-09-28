using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class FireRightIdle : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public FireRightIdle(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateFireRightIdleSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {
            mario.state = new FireLeftIdle(mario, game);
        }

        public void Right()
        {
            mario.state = new FireRightRunning(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.state = new FireRightCrouching(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.state = new FireRightJumping(mario, game);
        }

        public void Flower()
        {

        }

        public void Mushroom()
        {
            mario.state = new NormalRightIdle(mario, game);
        }

        public void Damage()
        {
            mario.state = new SmallRightIdle(mario, game);
        }

        public void Die()
        {
            mario.state = new Dead(mario, game);
        }

    }
}
