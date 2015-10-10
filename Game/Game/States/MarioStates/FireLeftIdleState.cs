using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class FireLeftIdleState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public FireLeftIdleState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSprite = SpriteFactories.MarioSpriteFactory.CreateFireLeftIdleSprite();
        }
        public void Update()
        {
            mario.GetSprite.Update();
        }

        public void Left()
        {
            mario.MarioStateProperty = new FireLeftRunningState(mario, game);
        }

        public void Right()
        {
            mario.MarioStateProperty = new FireRightIdleState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioStateProperty = new FireLeftCrouchingState(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.MarioStateProperty = new FireLeftJumpingState(mario, game);
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
            mario.MarioStateProperty = new NormalLeftIdleState(mario, game);
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
