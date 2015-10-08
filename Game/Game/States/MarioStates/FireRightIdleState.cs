using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class FireRightIdleState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public FireRightIdleState(MarioInstance mario, Game1 game)
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
            mario.state = new FireLeftIdleState(mario, game);
        }

        public void Right()
        {
            mario.state = new FireRightRunningState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.state = new FireRightCrouchingState(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.state = new FireRightJumpingState(mario, game);
        }

        public void Flower()
        {

        }

        public void Mushroom()
        {
            mario.state = new NormalRightIdleState(mario, game);
        }

        public void Damage()
        {
            mario.state = new SmallRightIdleState(mario, game);
        }

        public void Die()
        {
            mario.state = new DeadMarioState(mario, game);
        }
        public bool IsBig()
        {
            return true;
        }
    }
}
