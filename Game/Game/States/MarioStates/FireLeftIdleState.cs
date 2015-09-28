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

        public void Left()
        {
            mario.state = new FireLeftRunning(mario, game);
        }

        public void Right()
        {
            mario.state = new FireRightIdle(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.state = new FireLeftCrouching(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.state = new FireLeftJumping(mario, game);
        }

        public void Flower()
        {

        }

        public void Mushroom()
        {
            mario.state = new NormalLeftIdle(mario, game);
        }

        public void Damage()
        {
            mario.state = new SmallLeftIdle(mario, game);
        }

        public void Die()
        {
            mario.state = new Dead(mario, game);
        }


    }
}
