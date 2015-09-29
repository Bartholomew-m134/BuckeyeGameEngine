using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class FireLeftCrouchingState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public FireLeftCrouchingState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateFireLeftCrouchingSprite();
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
            mario.state = new FireLeftIdleState(mario, game);
        }

        public void Down()
        {

        }

        public void Land()
        {

        }

        public void Jump()
        {

        }

        public void Flower()
        {

        }

        public void Mushroom()
        {
            mario.state = new NormalLeftCrouchingState(mario, game);
        }

        public void Damage()
        {
            mario.state = new SmallLeftIdleState(mario, game);
        }

        public void Die()
        {
            mario.state = new DeadMarioState(mario, game);
        }


    }
}
