using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalLeftIdleState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public NormalLeftIdleState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftIdleSprite();
        }
        public void Update()
        {
            mario.GetSprite.Update();
        }

        public void Left()
        {
            mario.MarioStateProperty = new NormalLeftRunningState(mario, game);
        }

        public void Right()
        {
            mario.MarioStateProperty = new NormalRightIdleState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioStateProperty = new NormalLeftCrouchingState(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.MarioStateProperty = new NormalLeftJumpingState(mario, game);
        }

        public void Flower()
        {
            mario.MarioStateProperty = new FireLeftIdleState(mario, game);

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
            mario.MarioStateProperty = new SmallLeftIdleState(mario, game);
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
