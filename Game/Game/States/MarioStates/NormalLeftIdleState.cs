using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalLeftIdleState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;
        private IMario imario;

        public NormalLeftIdleState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            this.imario = (IMario)mario;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftIdleSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {
            mario.state = new NormalLeftRunningState(mario, game);
        }

        public void Right()
        {
            mario.state = new NormalRightIdleState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.state = new NormalLeftCrouchingState(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.state = new NormalLeftJumpingState(mario, game);
        }

        public void Flower()
        {
            mario.state = new FireLeftIdleState(mario, game);

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
            mario.state = new SmallLeftIdleState(mario, game);
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
