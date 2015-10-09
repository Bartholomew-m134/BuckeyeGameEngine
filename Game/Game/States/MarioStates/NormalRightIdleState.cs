using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalRightIdleState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;
        private IMario imario;

        public NormalRightIdleState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            this.imario = (IMario)mario;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightIdleSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {
            mario.state = new NormalLeftIdleState(mario, game);
        }

        public void Right()
        {
            mario.state = new NormalRightRunningState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.state = new NormalRightCrouchingState(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.state = new NormalRightJumpingState(mario, game);
        }

        public void Flower()
        {
            mario.state = new FireRightIdleState(mario, game);
        }

        public void Mushroom()
        {

        }

        public void Star()
        {
            imario = new StarMario(mario, game);
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
