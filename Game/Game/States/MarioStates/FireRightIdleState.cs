using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class FireRightIdleState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public FireRightIdleState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSprite = SpriteFactories.MarioSpriteFactory.CreateFireRightIdleSprite();
        }
        public void Update()
        {
            mario.GetSprite.Update();
        }

        public void Left()
        {
            mario.MarioStateProperty = new FireLeftIdleState(mario, game);
        }

        public void Right()
        {
            mario.MarioStateProperty = new FireRightRunningState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioStateProperty = new FireRightCrouchingState(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.MarioStateProperty = new FireRightJumpingState(mario, game);
        }

        public void Flower()
        {

        }

        public void Mushroom()
        {
        }

        public void Star()
        {
            mario = new StarMario(mario, game);
        }

        public void Damage()
        {
            mario.MarioStateProperty = new NormalRightIdleState(mario, game);
        }

        public void Die()
        {
            mario.MarioStateProperty = new DeadMarioState(mario, game);
        }
        public bool IsBig()
        {
            return true;
        }
    }
}
