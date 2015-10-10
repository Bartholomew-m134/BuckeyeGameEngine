using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    public class NormalRightIdleState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public NormalRightIdleState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightIdleSprite();
        }
        public void Update()
        {
            mario.GetSprite.Update();
        }

        public void Left()
        {
            mario.MarioStateProperty = new NormalLeftIdleState(mario, game);
        }

        public void Right()
        {
            mario.MarioStateProperty = new NormalRightRunningState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioStateProperty = new NormalRightCrouchingState(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.MarioStateProperty = new NormalRightJumpingState(mario, game);
        }

        public void Flower()
        {
            mario.MarioStateProperty = new FireRightIdleState(mario, game);
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
            mario.MarioStateProperty = new SmallRightIdleState(mario, game);
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
