using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalLeftCrouchingState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public NormalLeftCrouchingState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftCrouchingSprite();
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
            mario.state = new NormalLeftIdleState(mario, game);
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
            mario.state = new FireLeftCrouchingState(mario, game);
        }

        public void Mushroom()
        {

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
