using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class FireLeftJumpingState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public FireLeftJumpingState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateFireLeftJumpingSprite();
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
            mario.state = new FireLeftIdleState(mario, game);
        }

        public void Jump()
        {

        }

        public void Flower()
        {

        }

        public void Mushroom()
        {
            mario.state = new NormalLeftJumpingState(mario, game);
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
