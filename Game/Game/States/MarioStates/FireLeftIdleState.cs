using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class FireLeftIdleState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public FireLeftIdleState(MarioInstance mario, Game1 game)
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
            mario.state = new FireLeftRunningState(mario, game);
        }

        public void Right()
        {
            mario.state = new FireRightIdleState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.state = new FireLeftCrouchingState(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.state = new FireLeftJumpingState(mario, game);
        }

        public void Flower()
        {

        }

        public void Mushroom()
        {
            mario.state = new NormalLeftIdleState(mario, game);
        }

        public void Damage()
        {
            mario.state = new SmallLeftIdleState(mario, game);
        }

        public void Die()
        {
            mario.state = new DeadMarioState(mario, game);
        }


    }
}
