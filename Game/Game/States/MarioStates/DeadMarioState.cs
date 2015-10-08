using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;


namespace Game.States
{
    class DeadMarioState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public DeadMarioState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateDeadSprite();
        }

        public void Update() {
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

        }

        public void Jump()
        {

        }

        public void Flower()
        {
            mario.state = new FireRightIdleState(mario, game);
        }

        public void Mushroom()
        {
            mario.state = new NormalRightIdleState(mario, game);
        }

        public void Damage()
        {
            mario.state = new SmallRightIdleState(mario, game);
        }

        public void Die()
        {
            
        }
        public bool IsBig()
        {
            return false;
        }
    }
}
