using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    public class NormalLeftIdleState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public NormalLeftIdleState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftIdleSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            mario.GetSetMarioState = new NormalLeftRunningState(mario, game);
        }

        public void Right()
        {
            mario.GetSetMarioState = new NormalRightIdleState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.GetSetMarioState = new NormalLeftCrouchingState(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.GetSetMarioState = new NormalLeftJumpingState(mario, game);
        }

        public void Flower()
        {
            mario.GetSetMarioState = new FireLeftIdleState(mario, game);

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
            mario.GetSetMarioState = new SmallLeftIdleState(mario, game);
        }

        public void Die()
        {
            mario.GetSetMarioState = new DeadMarioState(mario, game);
        }
        public bool IsBig()
        {
            return true;
        }

        public void ToIdle()
        {

        }
    }
}
