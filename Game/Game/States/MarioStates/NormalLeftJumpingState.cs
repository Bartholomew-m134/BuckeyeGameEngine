using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalLeftJumpingState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public NormalLeftJumpingState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftJumpingSprite();
        }

        public void Update()
        {
            mario.sprite.Update();
        }
        public void Left()
        {

        }

        public void Right()
        {

        }

        public void Up()
        {

        }

        public void Down()
        {

        }

        public void Land()
        {
            mario.state = new NormalLeftIdleState(mario, game);
        }

        public void Jump()
        {

        }

        public void Flower()
        {
            mario.state = new FireLeftJumpingState(mario, game);
        }

        public void Mushroom()
        {

        }

        public void Damage()
        {
            mario.state = new SmallLeftJumpingState(mario, game);
        }

        public void Die()
        {
            mario.state = new DeadMarioState(mario, game);
        }

    }
}
